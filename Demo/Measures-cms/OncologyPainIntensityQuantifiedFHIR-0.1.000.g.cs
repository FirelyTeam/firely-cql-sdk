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
[CqlLibrary("OncologyPainIntensityQuantifiedFHIR", "0.1.000")]
public class OncologyPainIntensityQuantifiedFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Cancer;
    internal Lazy<CqlValueSet> __Chemotherapy_Administration;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Radiation_Treatment_Management;
    internal Lazy<CqlValueSet> __Standardized_Pain_Assessment_Tool;
    internal Lazy<CqlCode> __Radiation_treatment_management__5_treatments;
    internal Lazy<CqlCode[]> __CPT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Procedure>> __Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population_1;
    internal Lazy<IEnumerable<Encounter>> __Denominator_1;
    internal Lazy<IEnumerable<Encounter>> __Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population_2;
    internal Lazy<IEnumerable<Encounter>> __Denominator_2;
    internal Lazy<IEnumerable<Encounter>> __Numerator_1;
    internal Lazy<IEnumerable<Encounter>> __Numerator_2;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public OncologyPainIntensityQuantifiedFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        Status_1_6_000 = new Status_1_6_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);

        __Cancer = new Lazy<CqlValueSet>(this.Cancer_Value);
        __Chemotherapy_Administration = new Lazy<CqlValueSet>(this.Chemotherapy_Administration_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Radiation_Treatment_Management = new Lazy<CqlValueSet>(this.Radiation_Treatment_Management_Value);
        __Standardized_Pain_Assessment_Tool = new Lazy<CqlValueSet>(this.Standardized_Pain_Assessment_Tool_Value);
        __Radiation_treatment_management__5_treatments = new Lazy<CqlCode>(this.Radiation_treatment_management__5_treatments_Value);
        __CPT = new Lazy<CqlCode[]>(this.CPT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period = new Lazy<IEnumerable<Procedure>>(this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period_Value);
        __Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy = new Lazy<IEnumerable<Encounter>>(this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy_Value);
        __Initial_Population_1 = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_1_Value);
        __Denominator_1 = new Lazy<IEnumerable<Encounter>>(this.Denominator_1_Value);
        __Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis = new Lazy<IEnumerable<Encounter>>(this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis_Value);
        __Initial_Population_2 = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_2_Value);
        __Denominator_2 = new Lazy<IEnumerable<Encounter>>(this.Denominator_2_Value);
        __Numerator_1 = new Lazy<IEnumerable<Encounter>>(this.Numerator_1_Value);
        __Numerator_2 = new Lazy<IEnumerable<Encounter>>(this.Numerator_2_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }

    #endregion

	private CqlValueSet Cancer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1010", null);

    [CqlDeclaration("Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1010")]
	public CqlValueSet Cancer() => 
		__Cancer.Value;

	private CqlValueSet Chemotherapy_Administration_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1027", null);

    [CqlDeclaration("Chemotherapy Administration")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1027")]
	public CqlValueSet Chemotherapy_Administration() => 
		__Chemotherapy_Administration.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Radiation_Treatment_Management_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1026", null);

    [CqlDeclaration("Radiation Treatment Management")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1026")]
	public CqlValueSet Radiation_Treatment_Management() => 
		__Radiation_Treatment_Management.Value;

	private CqlValueSet Standardized_Pain_Assessment_Tool_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1028", null);

    [CqlDeclaration("Standardized Pain Assessment Tool")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1028")]
	public CqlValueSet Standardized_Pain_Assessment_Tool() => 
		__Standardized_Pain_Assessment_Tool.Value;

	private CqlCode Radiation_treatment_management__5_treatments_Value() => 
		new CqlCode("77427", "http://www.ama-assn.org/go/cpt", null, null);

    [CqlDeclaration("Radiation treatment management, 5 treatments")]
	public CqlCode Radiation_treatment_management__5_treatments() => 
		__Radiation_treatment_management__5_treatments.Value;

	private CqlCode[] CPT_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("77427", "http://www.ama-assn.org/go/cpt", null, null),
		};

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("OncologyPainIntensityQuantifiedFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Chemotherapy_Administration();
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		IEnumerable<Procedure> c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure ChemoAdministration)
		{
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period();
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlQuantity h_ = context.Operators.Quantity(31m, "days");
			CqlDateTime i_ = context.Operators.Subtract(g_, h_);
			CqlDateTime k_ = context.Operators.End(f_);
			CqlInterval<CqlDateTime> l_ = context.Operators.Interval(i_, k_, true, true);
			object m_ = FHIRHelpers_4_3_000.ToValue(ChemoAdministration?.Performed);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval(m_);
			bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, null);

			return o_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Chemotherapy Within 31 Days Prior and During Measurement Period")]
	public IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period() => 
		__Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		IEnumerable<Encounter> c_ = Status_1_6_000.Finished_Encounter(b_);
		IEnumerable<Procedure> d_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period();
		CqlValueSet f_ = this.Cancer();
		IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
		IEnumerable<ValueTuple<Encounter,Procedure,Procedure,Condition>> h_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure, Condition>(c_, d_, d_, g_);
		Tuple_HEhDGGHAahjZgibAaAMLGaSGT i_(ValueTuple<Encounter,Procedure,Procedure,Condition> _valueTuple)
		{
			Tuple_HEhDGGHAahjZgibAaAMLGaSGT o_ = new Tuple_HEhDGGHAahjZgibAaAMLGaSGT
			{
				FaceToFaceOrTelehealthEncounter = _valueTuple.Item1,
				ChemoBeforeEncounter = _valueTuple.Item2,
				ChemoAfterEncounter = _valueTuple.Item3,
				Cancer = _valueTuple.Item4,
			};

			return o_;
		};
		IEnumerable<Tuple_HEhDGGHAahjZgibAaAMLGaSGT> j_ = context.Operators.Select<ValueTuple<Encounter,Procedure,Procedure,Condition>, Tuple_HEhDGGHAahjZgibAaAMLGaSGT>(h_, i_);
		bool? k_(Tuple_HEhDGGHAahjZgibAaAMLGaSGT tuple_hehdgghaahjzgibaaamlgasgt)
		{
			bool? p_ = QICoreCommon_2_0_000.isActive(tuple_hehdgghaahjzgibaaamlgasgt.Cancer);
			CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.prevalenceInterval(tuple_hehdgghaahjzgibaaamlgasgt.Cancer);
			CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(tuple_hehdgghaahjzgibaaamlgasgt.FaceToFaceOrTelehealthEncounter?.Period);
			bool? s_ = context.Operators.Overlaps(q_, r_, null);
			bool? t_ = context.Operators.And(p_, s_);
			object u_ = FHIRHelpers_4_3_000.ToValue(tuple_hehdgghaahjzgibaaamlgasgt.ChemoBeforeEncounter?.Performed);
			CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.toInterval(u_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlDateTime y_ = context.Operators.End(r_);
			CqlQuantity z_ = context.Operators.Quantity(30m, "days");
			CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
			CqlDateTime ac_ = context.Operators.End(r_);
			CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(aa_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlDateTime>(w_, ad_, "day");
			CqlDateTime ag_ = context.Operators.End(r_);
			bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
			bool? ai_ = context.Operators.And(ae_, ah_);
			bool? aj_ = context.Operators.And(t_, ai_);
			object ak_ = FHIRHelpers_4_3_000.ToValue(tuple_hehdgghaahjzgibaaamlgasgt.ChemoAfterEncounter?.Performed);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.toInterval(ak_);
			CqlDateTime am_ = context.Operators.Start(al_);
			CqlDateTime ao_ = context.Operators.End(r_);
			CqlDateTime aq_ = context.Operators.End(r_);
			CqlDateTime as_ = context.Operators.Add(aq_, z_);
			CqlInterval<CqlDateTime> at_ = context.Operators.Interval(ao_, as_, true, true);
			bool? au_ = context.Operators.In<CqlDateTime>(am_, at_, "day");
			CqlDateTime aw_ = context.Operators.End(r_);
			bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
			bool? ay_ = context.Operators.And(au_, ax_);
			bool? az_ = context.Operators.And(aj_, ay_);
			CqlInterval<CqlDateTime> bb_ = QICoreCommon_2_0_000.toInterval(ak_);
			CqlInterval<CqlDateTime> bd_ = QICoreCommon_2_0_000.toInterval(u_);
			bool? be_ = context.Operators.SameAs<CqlDateTime>(bb_, bd_, "day");
			bool? bf_ = context.Operators.Not(be_);
			bool? bg_ = context.Operators.And(az_, bf_);
			CqlInterval<CqlDateTime> bh_ = this.Measurement_Period();
			bool? bj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bh_, r_, null);
			bool? bk_ = context.Operators.And(bg_, bj_);

			return bk_;
		};
		IEnumerable<Tuple_HEhDGGHAahjZgibAaAMLGaSGT> l_ = context.Operators.Where<Tuple_HEhDGGHAahjZgibAaAMLGaSGT>(j_, k_);
		Encounter m_(Tuple_HEhDGGHAahjZgibAaAMLGaSGT tuple_hehdgghaahjzgibaaamlgasgt) => 
			tuple_hehdgghaahjzgibaaamlgasgt.FaceToFaceOrTelehealthEncounter;
		IEnumerable<Encounter> n_ = context.Operators.Select<Tuple_HEhDGGHAahjZgibAaAMLGaSGT, Encounter>(l_, m_);

		return n_;
	}

    [CqlDeclaration("Face to Face or Telehealth Encounter with Ongoing Chemotherapy")]
	public IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy() => 
		__Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy.Value;

	private IEnumerable<Encounter> Initial_Population_1_Value()
	{
		IEnumerable<Encounter> a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy();

		return a_;
	}

    [CqlDeclaration("Initial Population 1")]
	public IEnumerable<Encounter> Initial_Population_1() => 
		__Initial_Population_1.Value;

	private IEnumerable<Encounter> Denominator_1_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population_1();

		return a_;
	}

    [CqlDeclaration("Denominator 1")]
	public IEnumerable<Encounter> Denominator_1() => 
		__Denominator_1.Value;

	private IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Radiation_Treatment_Management();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		IEnumerable<Encounter> c_ = Status_1_6_000.Finished_Encounter(b_);
		IEnumerable<Encounter> d_(Encounter RadiationTreatmentManagement)
		{
			CqlValueSet f_ = this.Cancer();
			IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			bool? h_(Condition Cancer)
			{
				bool? l_ = QICoreCommon_2_0_000.isActive(Cancer);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.prevalenceInterval(Cancer);
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(RadiationTreatmentManagement?.Period);
				bool? o_ = context.Operators.Overlaps(m_, n_, null);
				bool? p_ = context.Operators.And(l_, o_);
				CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
				bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, n_, null);
				bool? t_ = context.Operators.And(p_, s_);

				return t_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			Encounter j_(Condition Cancer) => 
				RadiationTreatmentManagement;
			IEnumerable<Encounter> k_ = context.Operators.Select<Condition, Encounter>(i_, j_);

			return k_;
		};
		IEnumerable<Encounter> e_ = context.Operators.SelectMany<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Radiation Treatment Management During Measurement Period with Cancer Diagnosis")]
	public IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis() => 
		__Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis.Value;

	private IEnumerable<Encounter> Initial_Population_2_Value()
	{
		IEnumerable<Encounter> a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis();

		return a_;
	}

    [CqlDeclaration("Initial Population 2")]
	public IEnumerable<Encounter> Initial_Population_2() => 
		__Initial_Population_2.Value;

	private IEnumerable<Encounter> Denominator_2_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population_2();

		return a_;
	}

    [CqlDeclaration("Denominator 2")]
	public IEnumerable<Encounter> Denominator_2() => 
		__Denominator_2.Value;

	private IEnumerable<Encounter> Numerator_1_Value()
	{
		IEnumerable<Encounter> a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy();
		IEnumerable<Encounter> b_(Encounter FaceToFaceOrTelehealthEncounterWithChemo)
		{
			CqlValueSet d_ = this.Standardized_Pain_Assessment_Tool();
			IEnumerable<Observation> e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation PainAssessed)
			{
				CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.ToInterval(FaceToFaceOrTelehealthEncounterWithChemo?.Period);
				object k_ = FHIRHelpers_4_3_000.ToValue(PainAssessed?.Effective);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.toInterval(k_);
				bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, null);
				object n_ = FHIRHelpers_4_3_000.ToValue(PainAssessed?.Value);
				bool? o_ = context.Operators.Not((bool?)(n_ is null));
				bool? p_ = context.Operators.And(m_, o_);
				Code<ObservationStatus> q_ = context.Operators.Convert<Code<ObservationStatus>>(PainAssessed?.StatusElement?.Value);
				bool? r_ = context.Operators.Equal(q_, "final");
				bool? s_ = context.Operators.And(p_, r_);

				return s_;
			};
			IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
			Encounter h_(Observation PainAssessed) => 
				FaceToFaceOrTelehealthEncounterWithChemo;
			IEnumerable<Encounter> i_ = context.Operators.Select<Observation, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator 1")]
	public IEnumerable<Encounter> Numerator_1() => 
		__Numerator_1.Value;

	private IEnumerable<Encounter> Numerator_2_Value()
	{
		IEnumerable<Encounter> a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis();
		IEnumerable<Encounter> b_(Encounter RadiationManagementEncounter)
		{
			CqlValueSet d_ = this.Standardized_Pain_Assessment_Tool();
			IEnumerable<Observation> e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation PainAssessed)
			{
				bool? j_()
				{
					bool q_()
					{
						CqlConcept r_(CodeableConcept @this)
						{
							CqlConcept w_ = FHIRHelpers_4_3_000.ToConcept(@this);

							return w_;
						};
						IEnumerable<CqlConcept> s_ = context.Operators.Select<CodeableConcept, CqlConcept>(RadiationManagementEncounter?.Type, r_);
						bool? t_(CqlConcept RadiationManagement)
						{
							CqlCode x_ = this.Radiation_treatment_management__5_treatments();
							CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
							bool? z_ = context.Operators.Equivalent(RadiationManagement, y_);

							return z_;
						};
						IEnumerable<CqlConcept> u_ = context.Operators.Where<CqlConcept>(s_, t_);
						bool? v_ = context.Operators.Exists<CqlConcept>(u_);

						return (v_ ?? false);
					};
					if (q_())
					{
						object aa_ = FHIRHelpers_4_3_000.ToValue(PainAssessed?.Effective);
						CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.toInterval(aa_);
						CqlDateTime ac_ = context.Operators.End(ab_);
						CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(RadiationManagementEncounter?.Period);
						CqlDateTime ae_ = context.Operators.Start(ad_);
						CqlQuantity af_ = context.Operators.Quantity(6m, "days");
						CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
						CqlDateTime ai_ = context.Operators.Start(ad_);
						CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(ag_, ai_, true, true);
						bool? ak_ = context.Operators.In<CqlDateTime>(ac_, aj_, "day");
						CqlDateTime am_ = context.Operators.Start(ad_);
						bool? an_ = context.Operators.Not((bool?)(am_ is null));
						bool? ao_ = context.Operators.And(ak_, an_);

						return ao_;
					}
					else
					{
						CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_3_000.ToInterval(RadiationManagementEncounter?.Period);
						object aq_ = FHIRHelpers_4_3_000.ToValue(PainAssessed?.Effective);
						CqlInterval<CqlDateTime> ar_ = QICoreCommon_2_0_000.toInterval(aq_);
						bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, ar_, "day");

						return as_;
					};
				};
				object k_ = FHIRHelpers_4_3_000.ToValue(PainAssessed?.Value);
				bool? l_ = context.Operators.Not((bool?)(k_ is null));
				bool? m_ = context.Operators.And(j_(), l_);
				Code<ObservationStatus> n_ = context.Operators.Convert<Code<ObservationStatus>>(PainAssessed?.StatusElement?.Value);
				bool? o_ = context.Operators.Equal(n_, "final");
				bool? p_ = context.Operators.And(m_, o_);

				return p_;
			};
			IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
			Encounter h_(Observation PainAssessed) => 
				RadiationManagementEncounter;
			IEnumerable<Encounter> i_ = context.Operators.Select<Observation, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator 2")]
	public IEnumerable<Encounter> Numerator_2() => 
		__Numerator_2.Value;

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
