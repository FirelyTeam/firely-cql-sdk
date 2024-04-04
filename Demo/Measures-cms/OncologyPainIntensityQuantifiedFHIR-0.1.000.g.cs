using System;
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
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("OncologyPainIntensityQuantifiedFHIR-0.1.000", "Measurement Period", e_);

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
			var m_ = FHIRHelpers_4_3_000.ToValue(ChemoAdministration?.Performed);
			var n_ = QICoreCommon_2_0_000.toInterval(m_);
			var o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, null);

			return o_;
		};
		var e_ = context.Operators.WhereOrNull<Procedure>(c_, d_);

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
		IEnumerable<Procedure> d_(Encounter _FaceToFaceOrTelehealthEncounter)
		{
			var q_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period();

			return q_;
		};
		Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT e_(Encounter _FaceToFaceOrTelehealthEncounter, Procedure _ChemoBeforeEncounter)
		{
			var r_ = new Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT
			{
				FaceToFaceOrTelehealthEncounter = _FaceToFaceOrTelehealthEncounter,
				ChemoBeforeEncounter = _ChemoBeforeEncounter,
			};

			return r_;
		};
		var f_ = context.Operators.SelectManyResultsOrNull<Encounter, Procedure, Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT>(c_, d_, e_);
		IEnumerable<Procedure> g_(Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT _FaceToFaceOrTelehealthEncounterChemoBeforeEncounter)
		{
			var s_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period();

			return s_;
		};
		Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT h_(Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT FaceToFaceOrTelehealthEncounterChemoBeforeEncounter, Procedure _ChemoAfterEncounter)
		{
			var t_ = new Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT
			{
				FaceToFaceOrTelehealthEncounter = FaceToFaceOrTelehealthEncounterChemoBeforeEncounter.FaceToFaceOrTelehealthEncounter,
				ChemoBeforeEncounter = FaceToFaceOrTelehealthEncounterChemoBeforeEncounter.ChemoBeforeEncounter,
				ChemoAfterEncounter = _ChemoAfterEncounter,
			};

			return t_;
		};
		var i_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT, Procedure, Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT>(f_, g_, h_);
		IEnumerable<Condition> j_(Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT _FaceToFaceOrTelehealthEncounterChemoBeforeEncounterChemoAfterEncounter)
		{
			var u_ = this.Cancer();
			var v_ = context.Operators.RetrieveByValueSet<Condition>(u_, null);

			return v_;
		};
		Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT k_(Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT FaceToFaceOrTelehealthEncounterChemoBeforeEncounterChemoAfterEncounter, Condition _Cancer)
		{
			var w_ = new Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT
			{
				FaceToFaceOrTelehealthEncounter = FaceToFaceOrTelehealthEncounterChemoBeforeEncounterChemoAfterEncounter.FaceToFaceOrTelehealthEncounter,
				ChemoBeforeEncounter = FaceToFaceOrTelehealthEncounterChemoBeforeEncounterChemoAfterEncounter.ChemoBeforeEncounter,
				ChemoAfterEncounter = FaceToFaceOrTelehealthEncounterChemoBeforeEncounterChemoAfterEncounter.ChemoAfterEncounter,
				Cancer = _Cancer,
			};

			return w_;
		};
		var l_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT, Condition, Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT>(i_, j_, k_);
		bool? m_(Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT tuple_hehdgghaahjzgibaaamlgasgt)
		{
			var x_ = QICoreCommon_2_0_000.isActive(tuple_hehdgghaahjzgibaaamlgasgt.Cancer);
			var y_ = QICoreCommon_2_0_000.prevalenceInterval(tuple_hehdgghaahjzgibaaamlgasgt.Cancer);
			var z_ = FHIRHelpers_4_3_000.ToInterval(tuple_hehdgghaahjzgibaaamlgasgt.FaceToFaceOrTelehealthEncounter?.Period);
			var aa_ = context.Operators.Overlaps(y_, z_, null);
			var ab_ = context.Operators.And(x_, aa_);
			var ac_ = FHIRHelpers_4_3_000.ToValue(tuple_hehdgghaahjzgibaaamlgasgt.ChemoBeforeEncounter?.Performed);
			var ad_ = QICoreCommon_2_0_000.toInterval(ac_);
			var ae_ = context.Operators.Start(ad_);
			var ag_ = context.Operators.End(z_);
			var ah_ = context.Operators.Quantity(30m, "days");
			var ai_ = context.Operators.Subtract(ag_, ah_);
			var ak_ = context.Operators.End(z_);
			var al_ = context.Operators.Interval(ai_, ak_, true, true);
			var am_ = context.Operators.ElementInInterval<CqlDateTime>(ae_, al_, "day");
			var ao_ = context.Operators.End(z_);
			var ap_ = context.Operators.Not((bool?)(ao_ is null));
			var aq_ = context.Operators.And(am_, ap_);
			var ar_ = context.Operators.And(ab_, aq_);
			var as_ = FHIRHelpers_4_3_000.ToValue(tuple_hehdgghaahjzgibaaamlgasgt.ChemoAfterEncounter?.Performed);
			var at_ = QICoreCommon_2_0_000.toInterval(as_);
			var au_ = context.Operators.Start(at_);
			var aw_ = context.Operators.End(z_);
			var ay_ = context.Operators.End(z_);
			var ba_ = context.Operators.Add(ay_, ah_);
			var bb_ = context.Operators.Interval(aw_, ba_, true, true);
			var bc_ = context.Operators.ElementInInterval<CqlDateTime>(au_, bb_, "day");
			var be_ = context.Operators.End(z_);
			var bf_ = context.Operators.Not((bool?)(be_ is null));
			var bg_ = context.Operators.And(bc_, bf_);
			var bh_ = context.Operators.And(ar_, bg_);
			var bj_ = QICoreCommon_2_0_000.toInterval(as_);
			var bl_ = QICoreCommon_2_0_000.toInterval(ac_);
			var bm_ = context.Operators.IntervalSameAs<CqlDateTime>(bj_, bl_, "day");
			var bn_ = context.Operators.Not(bm_);
			var bo_ = context.Operators.And(bh_, bn_);
			var bp_ = this.Measurement_Period();
			var br_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bp_, z_, null);
			var bs_ = context.Operators.And(bo_, br_);

			return bs_;
		};
		var n_ = context.Operators.WhereOrNull<Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT>(l_, m_);
		Encounter o_(Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT tuple_hehdgghaahjzgibaaamlgasgt) => 
			tuple_hehdgghaahjzgibaaamlgasgt.FaceToFaceOrTelehealthEncounter;
		var p_ = context.Operators.SelectOrNull<Tuples.Tuple_HEhDGGHAahjZgibAaAMLGaSGT, Encounter>(n_, o_);

		return p_;
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
				var n_ = FHIRHelpers_4_3_000.ToInterval(RadiationTreatmentManagement?.Period);
				var o_ = context.Operators.Overlaps(m_, n_, null);
				var p_ = context.Operators.And(l_, o_);
				var q_ = this.Measurement_Period();
				var s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, n_, null);
				var t_ = context.Operators.And(p_, s_);

				return t_;
			};
			var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);
			Encounter j_(Condition Cancer) => 
				RadiationTreatmentManagement;
			var k_ = context.Operators.SelectOrNull<Condition, Encounter>(i_, j_);

			return k_;
		};
		var e_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(c_, d_);

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
				var j_ = FHIRHelpers_4_3_000.ToInterval(FaceToFaceOrTelehealthEncounterWithChemo?.Period);
				var k_ = FHIRHelpers_4_3_000.ToValue(PainAssessed?.Effective);
				var l_ = QICoreCommon_2_0_000.toInterval(k_);
				var m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, null);
				var n_ = FHIRHelpers_4_3_000.ToValue(PainAssessed?.Value);
				var o_ = context.Operators.Not((bool?)(n_ is null));
				var p_ = context.Operators.And(m_, o_);
				var q_ = context.Operators.Convert<Code<ObservationStatus>>(PainAssessed?.StatusElement?.Value);
				var r_ = context.Operators.Equal(q_, "final");
				var s_ = context.Operators.And(p_, r_);

				return s_;
			};
			var g_ = context.Operators.WhereOrNull<Observation>(e_, f_);
			Encounter h_(Observation PainAssessed) => 
				FaceToFaceOrTelehealthEncounterWithChemo;
			var i_ = context.Operators.SelectOrNull<Observation, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

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
					if ((context.Operators.ExistsInList<CqlConcept>(context.Operators.WhereOrNull<CqlConcept>(context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(RadiationManagementEncounter?.Type, (CodeableConcept @this) => 
										FHIRHelpers_4_3_000.ToConcept(@this)), (CqlConcept RadiationManagement) => 
									context.Operators.Equivalent(RadiationManagement, context.Operators.ConvertCodeToConcept(this.Radiation_treatment_management__5_treatments())))) ?? false))
					{
						var q_ = FHIRHelpers_4_3_000.ToValue(PainAssessed?.Effective);
						var r_ = QICoreCommon_2_0_000.toInterval(q_);
						var s_ = context.Operators.End(r_);
						var t_ = FHIRHelpers_4_3_000.ToInterval(RadiationManagementEncounter?.Period);
						var u_ = context.Operators.Start(t_);
						var v_ = context.Operators.Quantity(6m, "days");
						var w_ = context.Operators.Subtract(u_, v_);
						var y_ = context.Operators.Start(t_);
						var z_ = context.Operators.Interval(w_, y_, true, true);
						var aa_ = context.Operators.ElementInInterval<CqlDateTime>(s_, z_, "day");
						var ac_ = context.Operators.Start(t_);
						var ad_ = context.Operators.Not((bool?)(ac_ is null));
						var ae_ = context.Operators.And(aa_, ad_);

						return ae_;
					}
					else
					{
						var af_ = FHIRHelpers_4_3_000.ToInterval(RadiationManagementEncounter?.Period);
						var ag_ = FHIRHelpers_4_3_000.ToValue(PainAssessed?.Effective);
						var ah_ = QICoreCommon_2_0_000.toInterval(ag_);
						var ai_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(af_, ah_, "day");

						return ai_;
					};
				};
				var k_ = FHIRHelpers_4_3_000.ToValue(PainAssessed?.Value);
				var l_ = context.Operators.Not((bool?)(k_ is null));
				var m_ = context.Operators.And(j_(), l_);
				var n_ = context.Operators.Convert<Code<ObservationStatus>>(PainAssessed?.StatusElement?.Value);
				var o_ = context.Operators.Equal(n_, "final");
				var p_ = context.Operators.And(m_, o_);

				return p_;
			};
			var g_ = context.Operators.WhereOrNull<Observation>(e_, f_);
			Encounter h_(Observation PainAssessed) => 
				RadiationManagementEncounter;
			var i_ = context.Operators.SelectOrNull<Observation, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator 2")]
	public IEnumerable<Encounter> Numerator_2() => 
		__Numerator_2.Value;

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

}
