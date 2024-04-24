using System;
using Tuples;
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
[CqlLibrary("AnticoagulationTherapyforAtrialFibrillationFlutterFHIR", "0.3.000")]
public class AnticoagulationTherapyforAtrialFibrillationFlutterFHIR_0_3_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Anticoagulant_Therapy;
    internal Lazy<CqlValueSet> __Atrial_Ablation;
    internal Lazy<CqlValueSet> __Atrial_Fibrillation_or_Flutter;
    internal Lazy<CqlValueSet> __Discharge_To_Acute_Care_Facility;
    internal Lazy<CqlValueSet> __Discharged_to_Health_Care_Facility_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Discharged_to_Home_for_Hospice_Care;
    internal Lazy<CqlValueSet> __History_of_Atrial_Ablation;
    internal Lazy<CqlValueSet> __Left_Against_Medical_Advice;
    internal Lazy<CqlValueSet> __Medical_Reason_For_Not_Providing_Treatment;
    internal Lazy<CqlValueSet> __Patient_Expired;
    internal Lazy<CqlValueSet> __Patient_Refusal;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_a_History_of_Atrial_Ablation;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<MedicationRequest>> __Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exceptions;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public AnticoagulationTherapyforAtrialFibrillationFlutterFHIR_0_3_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        TJCOverall_8_11_000 = new TJCOverall_8_11_000(context);

        __Anticoagulant_Therapy = new Lazy<CqlValueSet>(this.Anticoagulant_Therapy_Value);
        __Atrial_Ablation = new Lazy<CqlValueSet>(this.Atrial_Ablation_Value);
        __Atrial_Fibrillation_or_Flutter = new Lazy<CqlValueSet>(this.Atrial_Fibrillation_or_Flutter_Value);
        __Discharge_To_Acute_Care_Facility = new Lazy<CqlValueSet>(this.Discharge_To_Acute_Care_Facility_Value);
        __Discharged_to_Health_Care_Facility_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Health_Care_Facility_for_Hospice_Care_Value);
        __Discharged_to_Home_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Home_for_Hospice_Care_Value);
        __History_of_Atrial_Ablation = new Lazy<CqlValueSet>(this.History_of_Atrial_Ablation_Value);
        __Left_Against_Medical_Advice = new Lazy<CqlValueSet>(this.Left_Against_Medical_Advice_Value);
        __Medical_Reason_For_Not_Providing_Treatment = new Lazy<CqlValueSet>(this.Medical_Reason_For_Not_Providing_Treatment_Value);
        __Patient_Expired = new Lazy<CqlValueSet>(this.Patient_Expired_Value);
        __Patient_Refusal = new Lazy<CqlValueSet>(this.Patient_Refusal_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Encounter_with_a_History_of_Atrial_Ablation = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_a_History_of_Atrial_Ablation_Value);
        __Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusions_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge_Value);
        __Denominator_Exceptions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exceptions_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public TJCOverall_8_11_000 TJCOverall_8_11_000 { get; }

    #endregion

	private CqlValueSet Anticoagulant_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.200", null);

    [CqlDeclaration("Anticoagulant Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.200")]
	public CqlValueSet Anticoagulant_Therapy() => 
		__Anticoagulant_Therapy.Value;

	private CqlValueSet Atrial_Ablation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.203", null);

    [CqlDeclaration("Atrial Ablation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.203")]
	public CqlValueSet Atrial_Ablation() => 
		__Atrial_Ablation.Value;

	private CqlValueSet Atrial_Fibrillation_or_Flutter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202", null);

    [CqlDeclaration("Atrial Fibrillation or Flutter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202")]
	public CqlValueSet Atrial_Fibrillation_or_Flutter() => 
		__Atrial_Fibrillation_or_Flutter.Value;

	private CqlValueSet Discharge_To_Acute_Care_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility() => 
		__Discharge_To_Acute_Care_Facility.Value;

	private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => 
		__Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

	private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care() => 
		__Discharged_to_Home_for_Hospice_Care.Value;

	private CqlValueSet History_of_Atrial_Ablation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.76", null);

    [CqlDeclaration("History of Atrial Ablation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.76")]
	public CqlValueSet History_of_Atrial_Ablation() => 
		__History_of_Atrial_Ablation.Value;

	private CqlValueSet Left_Against_Medical_Advice_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
	public CqlValueSet Left_Against_Medical_Advice() => 
		__Left_Against_Medical_Advice.Value;

	private CqlValueSet Medical_Reason_For_Not_Providing_Treatment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlDeclaration("Medical Reason For Not Providing Treatment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
	public CqlValueSet Medical_Reason_For_Not_Providing_Treatment() => 
		__Medical_Reason_For_Not_Providing_Treatment.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Patient_Refusal_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlDeclaration("Patient Refusal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93")]
	public CqlValueSet Patient_Refusal() => 
		__Patient_Refusal.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var c_ = context.Operators.Interval(a_, b_, (bool?)true, (bool?)false);
		var d_ = context.ResolveParameter("AnticoagulationTherapyforAtrialFibrillationFlutterFHIR-0.3.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = TJCOverall_8_11_000.Encounter_with_Principal_Diagnosis_and_Age();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Encounter_with_a_History_of_Atrial_Ablation_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		bool? b_(Encounter IschemicStrokeEncounter)
		{
			var l_ = this.Atrial_Ablation();
			var m_ = context.Operators.RetrieveByValueSet<Procedure>(l_, null);
			bool? n_(Procedure AtrialAblationProcedure)
			{
				var q_ = context.Operators.Equal(AtrialAblationProcedure?.StatusElement?.Value, "completed");
				var r_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationProcedure?.Performed);
				var s_ = QICoreCommon_2_0_000.toInterval(r_);
				var t_ = context.Operators.Start(s_);
				var u_ = FHIRHelpers_4_3_000.ToInterval(IschemicStrokeEncounter?.Period);
				var v_ = context.Operators.Start(u_);
				var w_ = context.Operators.Before(t_, v_, null);
				var x_ = context.Operators.And(q_, w_);

				return x_;
			};
			var o_ = context.Operators.WhereOrNull<Procedure>(m_, n_);
			var p_ = context.Operators.Exists<Procedure>(o_);

			return p_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter IschemicStrokeEncounter)
		{
			var y_ = this.History_of_Atrial_Ablation();
			var z_ = context.Operators.RetrieveByValueSet<Condition>(y_, null);
			bool? aa_(Condition AtrialAblationDiagnosis)
			{
				var ae_ = FHIRHelpers_4_3_000.ToConcept(AtrialAblationDiagnosis?.VerificationStatus);
				var af_ = context.Operators.Not((bool?)(ae_ is null));
				var ah_ = QICoreCommon_2_0_000.confirmed();
				var ai_ = context.Operators.ConvertCodeToConcept(ah_);
				var aj_ = context.Operators.Equivalent(ae_, ai_);
				var ak_ = context.Operators.And(af_, aj_);
				var al_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationDiagnosis?.Onset);
				var am_ = QICoreCommon_2_0_000.toInterval(al_);
				var an_ = context.Operators.Start(am_);
				var ao_ = FHIRHelpers_4_3_000.ToInterval(IschemicStrokeEncounter?.Period);
				var ap_ = context.Operators.Start(ao_);
				var aq_ = context.Operators.Before(an_, ap_, null);
				var ar_ = context.Operators.And(ak_, aq_);

				return ar_;
			};
			var ab_ = context.Operators.WhereOrNull<Condition>(z_, aa_);
			Encounter ac_(Condition AtrialAblationDiagnosis) => 
				IschemicStrokeEncounter;
			var ad_ = context.Operators.SelectOrNull<Condition, Encounter>(ab_, ac_);

			return ad_;
		};
		var f_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, e_);
		var g_ = context.Operators.ListUnion<Encounter>(c_, f_);
		IEnumerable<Encounter> i_(Encounter IschemicStrokeEncounter)
		{
			var as_ = this.History_of_Atrial_Ablation();
			var at_ = context.Operators.RetrieveByValueSet<Observation>(as_, null);
			bool? au_(Observation AtrialAblationObservation)
			{
				var ay_ = context.Operators.Convert<Code<ObservationStatus>>(AtrialAblationObservation?.StatusElement?.Value);
				var az_ = context.Operators.Convert<string>(ay_);
				var ba_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bb_ = context.Operators.In<string>(az_, (ba_ as IEnumerable<string>));
				object bc_()
				{
					bool bi_()
					{
						var bl_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationObservation?.Effective);
						var bm_ = bl_ is CqlDateTime;

						return bm_;
					};
					bool bj_()
					{
						var bn_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationObservation?.Effective);
						var bo_ = bn_ is CqlInterval<CqlDateTime>;

						return bo_;
					};
					bool bk_()
					{
						var bp_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationObservation?.Effective);
						var bq_ = bp_ is CqlDateTime;

						return bq_;
					};
					if (bi_())
					{
						var br_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationObservation?.Effective);

						return ((br_ as CqlDateTime) as object);
					}
					else if (bj_())
					{
						var bs_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationObservation?.Effective);

						return ((bs_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (bk_())
					{
						var bt_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationObservation?.Effective);

						return ((bt_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				var bd_ = QICoreCommon_2_0_000.earliest(bc_());
				var be_ = FHIRHelpers_4_3_000.ToInterval(IschemicStrokeEncounter?.Period);
				var bf_ = context.Operators.End(be_);
				var bg_ = context.Operators.SameOrBefore(bd_, bf_, null);
				var bh_ = context.Operators.And(bb_, bg_);

				return bh_;
			};
			var av_ = context.Operators.WhereOrNull<Observation>(at_, au_);
			Encounter aw_(Observation AtrialAblationObservation) => 
				IschemicStrokeEncounter;
			var ax_ = context.Operators.SelectOrNull<Observation, Encounter>(av_, aw_);

			return ax_;
		};
		var j_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(g_, j_);

		return k_;
	}

    [CqlDeclaration("Encounter with a History of Atrial Ablation")]
	public IEnumerable<Encounter> Encounter_with_a_History_of_Atrial_Ablation() => 
		__Encounter_with_a_History_of_Atrial_Ablation.Value;

	private IEnumerable<Encounter> Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var h_ = this.Atrial_Fibrillation_or_Flutter();
			var i_ = context.Operators.RetrieveByValueSet<Condition>(h_, null);
			bool? j_(Condition AtrialFibrillationFlutter)
			{
				var n_ = FHIRHelpers_4_3_000.ToConcept(AtrialFibrillationFlutter?.VerificationStatus);
				var o_ = context.Operators.Not((bool?)(n_ is null));
				var q_ = QICoreCommon_2_0_000.confirmed();
				var r_ = context.Operators.ConvertCodeToConcept(q_);
				var s_ = context.Operators.Equivalent(n_, r_);
				var t_ = context.Operators.And(o_, s_);
				var u_ = FHIRHelpers_4_3_000.ToValue(AtrialFibrillationFlutter?.Onset);
				var v_ = QICoreCommon_2_0_000.toInterval(u_);
				var w_ = context.Operators.Start(v_);
				var x_ = FHIRHelpers_4_3_000.ToInterval(IschemicStrokeEncounter?.Period);
				var y_ = context.Operators.End(x_);
				var z_ = context.Operators.SameOrBefore(w_, y_, null);
				var aa_ = context.Operators.And(t_, z_);

				return aa_;
			};
			var k_ = context.Operators.WhereOrNull<Condition>(i_, j_);
			Encounter l_(Condition AtrialFibrillationFlutter) => 
				IschemicStrokeEncounter;
			var m_ = context.Operators.SelectOrNull<Condition, Encounter>(k_, l_);

			return m_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);
		bool? e_(Encounter IschemicStrokeEncounter)
		{
			var ab_ = CQMCommon_2_0_000.encounterDiagnosis(IschemicStrokeEncounter);
			bool? ac_(Condition EncounterDiagnosis)
			{
				var af_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				var ag_ = this.Atrial_Fibrillation_or_Flutter();
				var ah_ = context.Operators.ConceptInValueSet(af_, ag_);

				return ah_;
			};
			var ad_ = context.Operators.WhereOrNull<Condition>(ab_, ac_);
			var ae_ = context.Operators.Exists<Condition>(ad_);

			return ae_;
		};
		var f_ = context.Operators.WhereOrNull<Encounter>(a_, e_);
		var g_ = context.Operators.ListUnion<Encounter>(c_, f_);

		return g_;
	}

    [CqlDeclaration("Encounter with Prior or Present Diagnosis of Atrial Fibrillation or Flutter")]
	public IEnumerable<Encounter> Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter() => 
		__Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Encounter_with_a_History_of_Atrial_Ablation();
		var b_ = this.Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter();
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter_Value()
	{
		var a_ = this.Denominator();
		IEnumerable<Encounter> b_(Encounter Encounter)
		{
			var d_ = TJCOverall_8_11_000.Intervention_Comfort_Measures();
			bool? e_(object ComfortMeasure)
			{
				var i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				var j_ = FHIRHelpers_4_3_000.ToValue(i_);
				var k_ = QICoreCommon_2_0_000.toInterval(j_);
				var l_ = context.Operators.Start(k_);
				var m_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
				var n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
				var o_ = CQMCommon_2_0_000.hospitalizationWithObservation(Encounter);
				var p_ = context.Operators.In<CqlDateTime>((l_ ?? n_), o_, null);

				return p_;
			};
			var f_ = context.Operators.WhereOrNull<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				Encounter;
			var h_ = context.Operators.SelectOrNull<object, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization for Patients with Documented Atrial Fibrillation or Flutter")]
	public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter() => 
		__Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		var a_ = this.Denominator();
		bool? b_(Encounter Encounter)
		{
			var f_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(Encounter?.StatusElement?.Value);
			var g_ = context.Operators.Equal(f_, "finished");
			var h_ = FHIRHelpers_4_3_000.ToConcept(Encounter?.Hospitalization?.DischargeDisposition);
			var i_ = this.Discharge_To_Acute_Care_Facility();
			var j_ = context.Operators.ConceptInValueSet(h_, i_);
			var l_ = this.Left_Against_Medical_Advice();
			var m_ = context.Operators.ConceptInValueSet(h_, l_);
			var n_ = context.Operators.Or(j_, m_);
			var p_ = this.Patient_Expired();
			var q_ = context.Operators.ConceptInValueSet(h_, p_);
			var r_ = context.Operators.Or(n_, q_);
			var t_ = this.Discharged_to_Home_for_Hospice_Care();
			var u_ = context.Operators.ConceptInValueSet(h_, t_);
			var v_ = context.Operators.Or(r_, u_);
			var x_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care();
			var y_ = context.Operators.ConceptInValueSet(h_, x_);
			var z_ = context.Operators.Or(v_, y_);
			var aa_ = context.Operators.And(g_, z_);

			return aa_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		var d_ = this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter();
		var e_ = context.Operators.ListUnion<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Denominator();
		IEnumerable<Encounter> b_(Encounter Encounter)
		{
			var d_ = this.Anticoagulant_Therapy();
			var e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			var g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			var h_ = context.Operators.ListUnion<MedicationRequest>(e_, g_);
			bool? i_(MedicationRequest DischargeAnticoagulant)
			{
				var m_ = QICoreCommon_2_0_000.isCommunity(DischargeAnticoagulant);
				var n_ = QICoreCommon_2_0_000.isDischarge(DischargeAnticoagulant);
				var o_ = context.Operators.Or(m_, n_);
				var p_ = context.Operators.Convert<string>(DischargeAnticoagulant?.StatusElement?.Value);
				var q_ = new string[]
				{
					"active",
					"completed",
				};
				var r_ = context.Operators.In<string>(p_, (q_ as IEnumerable<string>));
				var s_ = context.Operators.And(o_, r_);
				var t_ = context.Operators.Convert<string>(DischargeAnticoagulant?.IntentElement?.Value);
				var u_ = new string[]
				{
					"order",
					"original-order",
					"reflex-order",
					"filler-order",
					"instance-order",
				};
				var v_ = context.Operators.In<string>(t_, (u_ as IEnumerable<string>));
				var w_ = context.Operators.And(s_, v_);
				var x_ = context.Operators.IsTrue(DischargeAnticoagulant?.DoNotPerformElement?.Value);
				var y_ = context.Operators.Not(x_);
				var z_ = context.Operators.And(w_, y_);
				var aa_ = context.Operators.Convert<CqlDateTime>(DischargeAnticoagulant?.AuthoredOnElement);
				var ab_ = FHIRHelpers_4_3_000.ToInterval(Encounter?.Period);
				var ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, null);
				var ad_ = context.Operators.And(z_, ac_);

				return ad_;
			};
			var j_ = context.Operators.WhereOrNull<MedicationRequest>(h_, i_);
			Encounter k_(MedicationRequest DischargeAnticoagulant) => 
				Encounter;
			var l_ = context.Operators.SelectOrNull<MedicationRequest, Encounter>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<MedicationRequest> Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge_Value()
	{
		var a_ = this.Anticoagulant_Therapy();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		bool? c_(MedicationRequest NoAnticoagulant)
		{
			CqlConcept e_(CodeableConcept @this)
			{
				var v_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return v_;
			};
			var f_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(NoAnticoagulant?.ReasonCode, e_);
			var g_ = this.Medical_Reason_For_Not_Providing_Treatment();
			var h_ = context.Operators.ConceptsInValueSet(f_, g_);
			CqlConcept i_(CodeableConcept @this)
			{
				var w_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return w_;
			};
			var j_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(NoAnticoagulant?.ReasonCode, i_);
			var k_ = this.Patient_Refusal();
			var l_ = context.Operators.ConceptsInValueSet(j_, k_);
			var m_ = context.Operators.Or(h_, l_);
			var n_ = QICoreCommon_2_0_000.isCommunity(NoAnticoagulant);
			var o_ = QICoreCommon_2_0_000.isDischarge(NoAnticoagulant);
			var p_ = context.Operators.Or(n_, o_);
			var q_ = context.Operators.And(m_, p_);
			var r_ = context.Operators.Convert<string>(NoAnticoagulant?.IntentElement?.Value);
			var s_ = new string[]
			{
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			};
			var t_ = context.Operators.In<string>(r_, (s_ as IEnumerable<string>));
			var u_ = context.Operators.And(q_, t_);

			return u_;
		};
		var d_ = context.Operators.WhereOrNull<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Documented Reason for Not Giving Anticoagulant at Discharge")]
	public IEnumerable<MedicationRequest> Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge() => 
		__Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		var a_ = this.Denominator();
		IEnumerable<Encounter> b_(Encounter Encounter)
		{
			var d_ = this.Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge();
			bool? e_(MedicationRequest NoDischargeAnticoagulant)
			{
				var i_ = context.Operators.Convert<CqlDateTime>(NoDischargeAnticoagulant?.AuthoredOnElement);
				var j_ = FHIRHelpers_4_3_000.ToInterval(Encounter?.Period);
				var k_ = context.Operators.In<CqlDateTime>(i_, j_, null);

				return k_;
			};
			var f_ = context.Operators.WhereOrNull<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest NoDischargeAnticoagulant) => 
				Encounter;
			var h_ = context.Operators.SelectOrNull<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
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
