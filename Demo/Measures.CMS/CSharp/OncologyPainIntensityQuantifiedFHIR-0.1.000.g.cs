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
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
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
		var a_ = new CqlCode[]
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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("OncologyPainIntensityQuantifiedFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period_Value()
	{
		var a_ = this.Chemotherapy_Administration();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure ChemoAdministration)
		{
			var f_ = this.Measurement_Period();
			var g_ = context.Operators.Start(f_);
			var h_ = context.Operators.Quantity(31m, "days");
			var i_ = context.Operators.Subtract(g_, h_);
			var k_ = context.Operators.End(f_);
			var l_ = context.Operators.Interval(i_, k_, true, true);
			var m_ = ChemoAdministration?.Performed;
			var n_ = FHIRHelpers_4_3_000.ToValue(m_);
			var o_ = QICoreCommon_2_0_000.toInterval(n_);
			var p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, null);

			return p_;
		};
		var e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Chemotherapy Within 31 Days Prior and During Measurement Period")]
	public IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period() => 
		__Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = Status_1_6_000.Finished_Encounter(b_);
		var d_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period();
		var f_ = this.Cancer();
		var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
		var h_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure, Condition>(c_, d_, d_, g_);
		Tuple_CIBLiGZRIHjLJQMiTHPOROaSe i_(ValueTuple<Encounter, Procedure, Procedure, Condition> _valueTuple)
		{
			var o_ = new Tuple_CIBLiGZRIHjLJQMiTHPOROaSe
			{
				FaceToFaceOrTelehealthEncounter = _valueTuple.Item1,
				ChemoBeforeEncounter = _valueTuple.Item2,
				ChemoAfterEncounter = _valueTuple.Item3,
				Cancer = _valueTuple.Item4,
			};

			return o_;
		};
		var j_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure, Condition>, Tuple_CIBLiGZRIHjLJQMiTHPOROaSe>(h_, i_);
		bool? k_(Tuple_CIBLiGZRIHjLJQMiTHPOROaSe tuple_cibligzrihjljqmithporoase)
		{
			var p_ = QICoreCommon_2_0_000.isActive(tuple_cibligzrihjljqmithporoase.Cancer);
			var q_ = QICoreCommon_2_0_000.prevalenceInterval(tuple_cibligzrihjljqmithporoase.Cancer);
			var r_ = tuple_cibligzrihjljqmithporoase.FaceToFaceOrTelehealthEncounter?.Period;
			var s_ = FHIRHelpers_4_3_000.ToInterval(r_);
			var t_ = context.Operators.Overlaps(q_, s_, null);
			var u_ = context.Operators.And(p_, t_);
			var v_ = tuple_cibligzrihjljqmithporoase.ChemoBeforeEncounter?.Performed;
			var w_ = FHIRHelpers_4_3_000.ToValue(v_);
			var x_ = QICoreCommon_2_0_000.toInterval(w_);
			var y_ = context.Operators.Start(x_);
			var aa_ = FHIRHelpers_4_3_000.ToInterval(r_);
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.Quantity(30m, "days");
			var ad_ = context.Operators.Subtract(ab_, ac_);
			var af_ = FHIRHelpers_4_3_000.ToInterval(r_);
			var ag_ = context.Operators.End(af_);
			var ah_ = context.Operators.Interval(ad_, ag_, true, true);
			var ai_ = context.Operators.In<CqlDateTime>(y_, ah_, "day");
			var ak_ = FHIRHelpers_4_3_000.ToInterval(r_);
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.And(u_, an_);
			var ap_ = tuple_cibligzrihjljqmithporoase.ChemoAfterEncounter?.Performed;
			var aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
			var ar_ = QICoreCommon_2_0_000.toInterval(aq_);
			var as_ = context.Operators.Start(ar_);
			var au_ = FHIRHelpers_4_3_000.ToInterval(r_);
			var av_ = context.Operators.End(au_);
			var ax_ = FHIRHelpers_4_3_000.ToInterval(r_);
			var ay_ = context.Operators.End(ax_);
			var ba_ = context.Operators.Add(ay_, ac_);
			var bb_ = context.Operators.Interval(av_, ba_, true, true);
			var bc_ = context.Operators.In<CqlDateTime>(as_, bb_, "day");
			var be_ = FHIRHelpers_4_3_000.ToInterval(r_);
			var bf_ = context.Operators.End(be_);
			var bg_ = context.Operators.Not((bool?)(bf_ is null));
			var bh_ = context.Operators.And(bc_, bg_);
			var bi_ = context.Operators.And(ao_, bh_);
			var bk_ = FHIRHelpers_4_3_000.ToValue(ap_);
			var bl_ = QICoreCommon_2_0_000.toInterval(bk_);
			var bn_ = FHIRHelpers_4_3_000.ToValue(v_);
			var bo_ = QICoreCommon_2_0_000.toInterval(bn_);
			var bp_ = context.Operators.SameAs<CqlDateTime>(bl_, bo_, "day");
			var bq_ = context.Operators.Not(bp_);
			var br_ = context.Operators.And(bi_, bq_);
			var bs_ = this.Measurement_Period();
			var bu_ = FHIRHelpers_4_3_000.ToInterval(r_);
			var bv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bs_, bu_, null);
			var bw_ = context.Operators.And(br_, bv_);

			return bw_;
		};
		var l_ = context.Operators.Where<Tuple_CIBLiGZRIHjLJQMiTHPOROaSe>(j_, k_);
		Encounter m_(Tuple_CIBLiGZRIHjLJQMiTHPOROaSe tuple_cibligzrihjljqmithporoase) => 
			tuple_cibligzrihjljqmithporoase.FaceToFaceOrTelehealthEncounter;
		var n_ = context.Operators.Select<Tuple_CIBLiGZRIHjLJQMiTHPOROaSe, Encounter>(l_, m_);

		return n_;
	}

    [CqlDeclaration("Face to Face or Telehealth Encounter with Ongoing Chemotherapy")]
	public IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy() => 
		__Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy.Value;

	private IEnumerable<Encounter> Initial_Population_1_Value()
	{
		var a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy();

		return a_;
	}

    [CqlDeclaration("Initial Population 1")]
	public IEnumerable<Encounter> Initial_Population_1() => 
		__Initial_Population_1.Value;

	private IEnumerable<Encounter> Denominator_1_Value()
	{
		var a_ = this.Initial_Population_1();

		return a_;
	}

    [CqlDeclaration("Denominator 1")]
	public IEnumerable<Encounter> Denominator_1() => 
		__Denominator_1.Value;

	private IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis_Value()
	{
		var a_ = this.Radiation_Treatment_Management();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = Status_1_6_000.Finished_Encounter(b_);
		IEnumerable<Encounter> d_(Encounter RadiationTreatmentManagement)
		{
			var f_ = this.Cancer();
			var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			bool? h_(Condition Cancer)
			{
				var l_ = QICoreCommon_2_0_000.isActive(Cancer);
				var m_ = QICoreCommon_2_0_000.prevalenceInterval(Cancer);
				var n_ = RadiationTreatmentManagement?.Period;
				var o_ = FHIRHelpers_4_3_000.ToInterval(n_);
				var p_ = context.Operators.Overlaps(m_, o_, null);
				var q_ = context.Operators.And(l_, p_);
				var r_ = this.Measurement_Period();
				var t_ = FHIRHelpers_4_3_000.ToInterval(n_);
				var u_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, t_, null);
				var v_ = context.Operators.And(q_, u_);

				return v_;
			};
			var i_ = context.Operators.Where<Condition>(g_, h_);
			Encounter j_(Condition Cancer) => 
				RadiationTreatmentManagement;
			var k_ = context.Operators.Select<Condition, Encounter>(i_, j_);

			return k_;
		};
		var e_ = context.Operators.SelectMany<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Radiation Treatment Management During Measurement Period with Cancer Diagnosis")]
	public IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis() => 
		__Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis.Value;

	private IEnumerable<Encounter> Initial_Population_2_Value()
	{
		var a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis();

		return a_;
	}

    [CqlDeclaration("Initial Population 2")]
	public IEnumerable<Encounter> Initial_Population_2() => 
		__Initial_Population_2.Value;

	private IEnumerable<Encounter> Denominator_2_Value()
	{
		var a_ = this.Initial_Population_2();

		return a_;
	}

    [CqlDeclaration("Denominator 2")]
	public IEnumerable<Encounter> Denominator_2() => 
		__Denominator_2.Value;

	private IEnumerable<Encounter> Numerator_1_Value()
	{
		var a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy();
		IEnumerable<Encounter> b_(Encounter FaceToFaceOrTelehealthEncounterWithChemo)
		{
			var d_ = this.Standardized_Pain_Assessment_Tool();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation PainAssessed)
			{
				var j_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
				var k_ = FHIRHelpers_4_3_000.ToInterval(j_);
				var l_ = PainAssessed?.Effective;
				var m_ = FHIRHelpers_4_3_000.ToValue(l_);
				var n_ = QICoreCommon_2_0_000.toInterval(m_);
				var o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, n_, null);
				var p_ = PainAssessed?.Value;
				var q_ = FHIRHelpers_4_3_000.ToValue(p_);
				var r_ = context.Operators.Not((bool?)(q_ is null));
				var s_ = context.Operators.And(o_, r_);
				var t_ = PainAssessed?.StatusElement;
				var u_ = t_?.Value;
				var v_ = context.Operators.Convert<Code<ObservationStatus>>(u_);
				var w_ = context.Operators.Equal(v_, "final");
				var x_ = context.Operators.And(s_, w_);

				return x_;
			};
			var g_ = context.Operators.Where<Observation>(e_, f_);
			Encounter h_(Observation PainAssessed) => 
				FaceToFaceOrTelehealthEncounterWithChemo;
			var i_ = context.Operators.Select<Observation, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator 1")]
	public IEnumerable<Encounter> Numerator_1() => 
		__Numerator_1.Value;

	private IEnumerable<Encounter> Numerator_2_Value()
	{
		var a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis();
		IEnumerable<Encounter> b_(Encounter RadiationManagementEncounter)
		{
			var d_ = this.Standardized_Pain_Assessment_Tool();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation PainAssessed)
			{
				bool? j_()
				{
					bool t_()
					{
						var u_ = RadiationManagementEncounter?.Type;
						CqlConcept v_(CodeableConcept @this)
						{
							var aa_ = FHIRHelpers_4_3_000.ToConcept(@this);

							return aa_;
						};
						var w_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)u_, v_);
						bool? x_(CqlConcept RadiationManagement)
						{
							var ab_ = this.Radiation_treatment_management__5_treatments();
							var ac_ = context.Operators.ConvertCodeToConcept(ab_);
							var ad_ = context.Operators.Equivalent(RadiationManagement, ac_);

							return ad_;
						};
						var y_ = context.Operators.Where<CqlConcept>(w_, x_);
						var z_ = context.Operators.Exists<CqlConcept>(y_);

						return (z_ ?? false);
					};
					if (t_())
					{
						var ae_ = PainAssessed?.Effective;
						var af_ = FHIRHelpers_4_3_000.ToValue(ae_);
						var ag_ = QICoreCommon_2_0_000.toInterval(af_);
						var ah_ = context.Operators.End(ag_);
						var ai_ = RadiationManagementEncounter?.Period;
						var aj_ = FHIRHelpers_4_3_000.ToInterval(ai_);
						var ak_ = context.Operators.Start(aj_);
						var al_ = context.Operators.Quantity(6m, "days");
						var am_ = context.Operators.Subtract(ak_, al_);
						var ao_ = FHIRHelpers_4_3_000.ToInterval(ai_);
						var ap_ = context.Operators.Start(ao_);
						var aq_ = context.Operators.Interval(am_, ap_, true, true);
						var ar_ = context.Operators.In<CqlDateTime>(ah_, aq_, "day");
						var at_ = FHIRHelpers_4_3_000.ToInterval(ai_);
						var au_ = context.Operators.Start(at_);
						var av_ = context.Operators.Not((bool?)(au_ is null));
						var aw_ = context.Operators.And(ar_, av_);

						return aw_;
					}
					else
					{
						var ax_ = RadiationManagementEncounter?.Period;
						var ay_ = FHIRHelpers_4_3_000.ToInterval(ax_);
						var az_ = PainAssessed?.Effective;
						var ba_ = FHIRHelpers_4_3_000.ToValue(az_);
						var bb_ = QICoreCommon_2_0_000.toInterval(ba_);
						var bc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ay_, bb_, "day");

						return bc_;
					}
				};
				var k_ = PainAssessed?.Value;
				var l_ = FHIRHelpers_4_3_000.ToValue(k_);
				var m_ = context.Operators.Not((bool?)(l_ is null));
				var n_ = context.Operators.And(j_(), m_);
				var o_ = PainAssessed?.StatusElement;
				var p_ = o_?.Value;
				var q_ = context.Operators.Convert<Code<ObservationStatus>>(p_);
				var r_ = context.Operators.Equal(q_, "final");
				var s_ = context.Operators.And(n_, r_);

				return s_;
			};
			var g_ = context.Operators.Where<Observation>(e_, f_);
			Encounter h_(Observation PainAssessed) => 
				RadiationManagementEncounter;
			var i_ = context.Operators.Select<Observation, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator 2")]
	public IEnumerable<Encounter> Numerator_2() => 
		__Numerator_2.Value;

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
