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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1010", default);

    [CqlDeclaration("Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1010")]
	public CqlValueSet Cancer() => 
		__Cancer.Value;

	private CqlValueSet Chemotherapy_Administration_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1027", default);

    [CqlDeclaration("Chemotherapy Administration")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1027")]
	public CqlValueSet Chemotherapy_Administration() => 
		__Chemotherapy_Administration.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Radiation_Treatment_Management_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1026", default);

    [CqlDeclaration("Radiation Treatment Management")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1026")]
	public CqlValueSet Radiation_Treatment_Management() => 
		__Radiation_Treatment_Management.Value;

	private CqlValueSet Standardized_Pain_Assessment_Tool_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1028", default);

    [CqlDeclaration("Standardized Pain Assessment Tool")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1028")]
	public CqlValueSet Standardized_Pain_Assessment_Tool() => 
		__Standardized_Pain_Assessment_Tool.Value;

	private CqlCode Radiation_treatment_management__5_treatments_Value() => 
		new CqlCode("77427", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("Radiation treatment management, 5 treatments")]
	public CqlCode Radiation_treatment_management__5_treatments() => 
		__Radiation_treatment_management__5_treatments.Value;

	private CqlCode[] CPT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("77427", "http://www.ama-assn.org/go/cpt", default, default),
		];

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
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Chemotherapy_Administration();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure ChemoAdministration)
		{
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period();
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlQuantity h_ = context.Operators.Quantity(31m, "days");
			CqlDateTime i_ = context.Operators.Subtract(g_, h_);
			CqlDateTime k_ = context.Operators.End(f_);
			CqlInterval<CqlDateTime> l_ = context.Operators.Interval(i_, k_, true, true);
			DataType m_ = ChemoAdministration?.Performed;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.toInterval(n_);
			bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, default);

			return p_;
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
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> c_ = Status_1_6_000.Finished_Encounter(b_);
		IEnumerable<Procedure> d_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period();
		CqlValueSet f_ = this.Cancer();
		IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<ValueTuple<Encounter, Procedure, Procedure, Condition>> h_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure, Condition>(c_, d_, d_, g_);
		(Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? i_(ValueTuple<Encounter, Procedure, Procedure, Condition> _valueTuple)
		{
			(Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? o_ = (_valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

			return o_;
		};
		IEnumerable<(Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> j_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure, Condition>, (Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(h_, i_);
		bool? k_((Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase)
		{
			bool? p_ = QICoreCommon_2_0_000.isActive(tuple_cibligzrihjljqmithporoase?.Cancer);
			CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.prevalenceInterval(tuple_cibligzrihjljqmithporoase?.Cancer);
			Period r_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.Period;
			CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.ToInterval(r_);
			bool? t_ = context.Operators.Overlaps(q_, s_, default);
			bool? u_ = context.Operators.And(p_, t_);
			DataType v_ = tuple_cibligzrihjljqmithporoase?.ChemoBeforeEncounter?.Performed;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.toInterval(w_);
			CqlDateTime y_ = context.Operators.Start(x_);
			CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.ToInterval(r_);
			CqlDateTime ab_ = context.Operators.End(aa_);
			CqlQuantity ac_ = context.Operators.Quantity(30m, "days");
			CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
			CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.ToInterval(r_);
			CqlDateTime ag_ = context.Operators.End(af_);
			CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ad_, ag_, true, true);
			bool? ai_ = context.Operators.In<CqlDateTime>(y_, ah_, "day");
			CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(r_);
			CqlDateTime al_ = context.Operators.End(ak_);
			bool? am_ = context.Operators.Not((bool?)(al_ is null));
			bool? an_ = context.Operators.And(ai_, am_);
			bool? ao_ = context.Operators.And(u_, an_);
			DataType ap_ = tuple_cibligzrihjljqmithporoase?.ChemoAfterEncounter?.Performed;
			object aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
			CqlInterval<CqlDateTime> ar_ = QICoreCommon_2_0_000.toInterval(aq_);
			CqlDateTime as_ = context.Operators.Start(ar_);
			CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_3_000.ToInterval(r_);
			CqlDateTime av_ = context.Operators.End(au_);
			CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_3_000.ToInterval(r_);
			CqlDateTime ay_ = context.Operators.End(ax_);
			CqlDateTime ba_ = context.Operators.Add(ay_, ac_);
			CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(av_, ba_, true, true);
			bool? bc_ = context.Operators.In<CqlDateTime>(as_, bb_, "day");
			CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_3_000.ToInterval(r_);
			CqlDateTime bf_ = context.Operators.End(be_);
			bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
			bool? bh_ = context.Operators.And(bc_, bg_);
			bool? bi_ = context.Operators.And(ao_, bh_);
			object bk_ = FHIRHelpers_4_3_000.ToValue(ap_);
			CqlInterval<CqlDateTime> bl_ = QICoreCommon_2_0_000.toInterval(bk_);
			object bn_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlInterval<CqlDateTime> bo_ = QICoreCommon_2_0_000.toInterval(bn_);
			bool? bp_ = context.Operators.SameAs<CqlDateTime>(bl_, bo_, "day");
			bool? bq_ = context.Operators.Not(bp_);
			bool? br_ = context.Operators.And(bi_, bq_);
			CqlInterval<CqlDateTime> bs_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_3_000.ToInterval(r_);
			bool? bv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bs_, bu_, default);
			bool? bw_ = context.Operators.And(br_, bv_);

			return bw_;
		};
		IEnumerable<(Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> l_ = context.Operators.Where<(Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(j_, k_);
		Encounter m_((Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase) => 
			tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter;
		IEnumerable<Encounter> n_ = context.Operators.Select<(Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?, Encounter>(l_, m_);

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
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> c_ = Status_1_6_000.Finished_Encounter(b_);
		IEnumerable<Encounter> d_(Encounter RadiationTreatmentManagement)
		{
			CqlValueSet f_ = this.Cancer();
			IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			bool? h_(Condition Cancer)
			{
				bool? l_ = QICoreCommon_2_0_000.isActive(Cancer);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.prevalenceInterval(Cancer);
				Period n_ = RadiationTreatmentManagement?.Period;
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.ToInterval(n_);
				bool? p_ = context.Operators.Overlaps(m_, o_, default);
				bool? q_ = context.Operators.And(l_, p_);
				CqlInterval<CqlDateTime> r_ = this.Measurement_Period();
				CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.ToInterval(n_);
				bool? u_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, t_, default);
				bool? v_ = context.Operators.And(q_, u_);

				return v_;
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
			IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
			bool? f_(Observation PainAssessed)
			{
				Period j_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
				CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.ToInterval(j_);
				DataType l_ = PainAssessed?.Effective;
				object m_ = FHIRHelpers_4_3_000.ToValue(l_);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval(m_);
				bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, n_, default);
				DataType p_ = PainAssessed?.Value;
				object q_ = FHIRHelpers_4_3_000.ToValue(p_);
				bool? r_ = context.Operators.Not((bool?)(q_ is null));
				bool? s_ = context.Operators.And(o_, r_);
				Code<ObservationStatus> t_ = PainAssessed?.StatusElement;
				ObservationStatus? u_ = t_?.Value;
				Code<ObservationStatus> v_ = context.Operators.Convert<Code<ObservationStatus>>(u_);
				bool? w_ = context.Operators.Equal(v_, "final");
				bool? x_ = context.Operators.And(s_, w_);

				return x_;
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
			IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
			bool? f_(Observation PainAssessed)
			{
				bool? j_()
				{
					bool t_()
					{
						List<CodeableConcept> u_ = RadiationManagementEncounter?.Type;
						CqlConcept v_(CodeableConcept @this)
						{
							CqlConcept aa_ = FHIRHelpers_4_3_000.ToConcept(@this);

							return aa_;
						};
						IEnumerable<CqlConcept> w_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)u_, v_);
						bool? x_(CqlConcept RadiationManagement)
						{
							CqlCode ab_ = this.Radiation_treatment_management__5_treatments();
							CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
							bool? ad_ = context.Operators.Equivalent(RadiationManagement, ac_);

							return ad_;
						};
						IEnumerable<CqlConcept> y_ = context.Operators.Where<CqlConcept>(w_, x_);
						bool? z_ = context.Operators.Exists<CqlConcept>(y_);

						return z_ ?? false;
					};
					if (t_())
					{
						DataType ae_ = PainAssessed?.Effective;
						object af_ = FHIRHelpers_4_3_000.ToValue(ae_);
						CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.toInterval(af_);
						CqlDateTime ah_ = context.Operators.End(ag_);
						Period ai_ = RadiationManagementEncounter?.Period;
						CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(ai_);
						CqlDateTime ak_ = context.Operators.Start(aj_);
						CqlQuantity al_ = context.Operators.Quantity(6m, "days");
						CqlDateTime am_ = context.Operators.Subtract(ak_, al_);
						CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_3_000.ToInterval(ai_);
						CqlDateTime ap_ = context.Operators.Start(ao_);
						CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(am_, ap_, true, true);
						bool? ar_ = context.Operators.In<CqlDateTime>(ah_, aq_, "day");
						CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_3_000.ToInterval(ai_);
						CqlDateTime au_ = context.Operators.Start(at_);
						bool? av_ = context.Operators.Not((bool?)(au_ is null));
						bool? aw_ = context.Operators.And(ar_, av_);

						return aw_;
					}
					else
					{
						Period ax_ = RadiationManagementEncounter?.Period;
						CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_3_000.ToInterval(ax_);
						DataType az_ = PainAssessed?.Effective;
						object ba_ = FHIRHelpers_4_3_000.ToValue(az_);
						CqlInterval<CqlDateTime> bb_ = QICoreCommon_2_0_000.toInterval(ba_);
						bool? bc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ay_, bb_, "day");

						return bc_;
					}
				};
				DataType k_ = PainAssessed?.Value;
				object l_ = FHIRHelpers_4_3_000.ToValue(k_);
				bool? m_ = context.Operators.Not((bool?)(l_ is null));
				bool? n_ = context.Operators.And(j_(), m_);
				Code<ObservationStatus> o_ = PainAssessed?.StatusElement;
				ObservationStatus? p_ = o_?.Value;
				Code<ObservationStatus> q_ = context.Operators.Convert<Code<ObservationStatus>>(p_);
				bool? r_ = context.Operators.Equal(q_, "final");
				bool? s_ = context.Operators.And(n_, r_);

				return s_;
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

}
