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
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
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
				var q_ = AtrialAblationProcedure?.StatusElement;
				var r_ = q_?.Value;
				var s_ = context.Operators.Convert<string>(r_);
				var t_ = context.Operators.Equal(s_, "completed");
				var u_ = AtrialAblationProcedure?.Performed;
				var v_ = FHIRHelpers_4_3_000.ToValue(u_);
				var w_ = QICoreCommon_2_0_000.toInterval(v_);
				var x_ = context.Operators.Start(w_);
				var y_ = IschemicStrokeEncounter?.Period;
				var z_ = FHIRHelpers_4_3_000.ToInterval(y_);
				var aa_ = context.Operators.Start(z_);
				var ab_ = context.Operators.Before(x_, aa_, null);
				var ac_ = context.Operators.And(t_, ab_);

				return ac_;
			};
			var o_ = context.Operators.Where<Procedure>(m_, n_);
			var p_ = context.Operators.Exists<Procedure>(o_);

			return p_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter IschemicStrokeEncounter)
		{
			var ad_ = this.History_of_Atrial_Ablation();
			var ae_ = context.Operators.RetrieveByValueSet<Condition>(ad_, null);
			bool? af_(Condition AtrialAblationDiagnosis)
			{
				var aj_ = AtrialAblationDiagnosis?.VerificationStatus;
				var ak_ = FHIRHelpers_4_3_000.ToConcept(aj_);
				var al_ = context.Operators.Not((bool?)(ak_ is null));
				var an_ = FHIRHelpers_4_3_000.ToConcept(aj_);
				var ao_ = QICoreCommon_2_0_000.confirmed();
				var ap_ = context.Operators.ConvertCodeToConcept(ao_);
				var aq_ = context.Operators.Equivalent(an_, ap_);
				var ar_ = context.Operators.And(al_, aq_);
				var as_ = AtrialAblationDiagnosis?.Onset;
				var at_ = FHIRHelpers_4_3_000.ToValue(as_);
				var au_ = QICoreCommon_2_0_000.toInterval(at_);
				var av_ = context.Operators.Start(au_);
				var aw_ = IschemicStrokeEncounter?.Period;
				var ax_ = FHIRHelpers_4_3_000.ToInterval(aw_);
				var ay_ = context.Operators.Start(ax_);
				var az_ = context.Operators.Before(av_, ay_, null);
				var ba_ = context.Operators.And(ar_, az_);

				return ba_;
			};
			var ag_ = context.Operators.Where<Condition>(ae_, af_);
			Encounter ah_(Condition AtrialAblationDiagnosis) => 
				IschemicStrokeEncounter;
			var ai_ = context.Operators.Select<Condition, Encounter>(ag_, ah_);

			return ai_;
		};
		var f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		var g_ = context.Operators.ListUnion<Encounter>(c_, f_);
		IEnumerable<Encounter> i_(Encounter IschemicStrokeEncounter)
		{
			var bb_ = this.History_of_Atrial_Ablation();
			var bc_ = context.Operators.RetrieveByValueSet<Observation>(bb_, null);
			bool? bd_(Observation AtrialAblationObservation)
			{
				var bh_ = AtrialAblationObservation?.StatusElement;
				var bi_ = bh_?.Value;
				var bj_ = context.Operators.Convert<Code<ObservationStatus>>(bi_);
				var bk_ = context.Operators.Convert<string>(bj_);
				var bl_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bm_ = context.Operators.In<string>(bk_, (bl_ as IEnumerable<string>));
				object bn_()
				{
					bool bu_()
					{
						var bx_ = AtrialAblationObservation?.Effective;
						var by_ = FHIRHelpers_4_3_000.ToValue(bx_);
						var bz_ = by_ is CqlDateTime;

						return bz_;
					};
					bool bv_()
					{
						var ca_ = AtrialAblationObservation?.Effective;
						var cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
						var cc_ = cb_ is CqlInterval<CqlDateTime>;

						return cc_;
					};
					bool bw_()
					{
						var cd_ = AtrialAblationObservation?.Effective;
						var ce_ = FHIRHelpers_4_3_000.ToValue(cd_);
						var cf_ = ce_ is CqlDateTime;

						return cf_;
					};
					if (bu_())
					{
						var cg_ = AtrialAblationObservation?.Effective;
						var ch_ = FHIRHelpers_4_3_000.ToValue(cg_);

						return ((ch_ as CqlDateTime) as object);
					}
					else if (bv_())
					{
						var ci_ = AtrialAblationObservation?.Effective;
						var cj_ = FHIRHelpers_4_3_000.ToValue(ci_);

						return ((cj_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (bw_())
					{
						var ck_ = AtrialAblationObservation?.Effective;
						var cl_ = FHIRHelpers_4_3_000.ToValue(ck_);

						return ((cl_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				var bo_ = QICoreCommon_2_0_000.earliest(bn_());
				var bp_ = IschemicStrokeEncounter?.Period;
				var bq_ = FHIRHelpers_4_3_000.ToInterval(bp_);
				var br_ = context.Operators.End(bq_);
				var bs_ = context.Operators.SameOrBefore(bo_, br_, null);
				var bt_ = context.Operators.And(bm_, bs_);

				return bt_;
			};
			var be_ = context.Operators.Where<Observation>(bc_, bd_);
			Encounter bf_(Observation AtrialAblationObservation) => 
				IschemicStrokeEncounter;
			var bg_ = context.Operators.Select<Observation, Encounter>(be_, bf_);

			return bg_;
		};
		var j_ = context.Operators.SelectMany<Encounter, Encounter>(a_, i_);
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
				var n_ = AtrialFibrillationFlutter?.VerificationStatus;
				var o_ = FHIRHelpers_4_3_000.ToConcept(n_);
				var p_ = context.Operators.Not((bool?)(o_ is null));
				var r_ = FHIRHelpers_4_3_000.ToConcept(n_);
				var s_ = QICoreCommon_2_0_000.confirmed();
				var t_ = context.Operators.ConvertCodeToConcept(s_);
				var u_ = context.Operators.Equivalent(r_, t_);
				var v_ = context.Operators.And(p_, u_);
				var w_ = AtrialFibrillationFlutter?.Onset;
				var x_ = FHIRHelpers_4_3_000.ToValue(w_);
				var y_ = QICoreCommon_2_0_000.toInterval(x_);
				var z_ = context.Operators.Start(y_);
				var aa_ = IschemicStrokeEncounter?.Period;
				var ab_ = FHIRHelpers_4_3_000.ToInterval(aa_);
				var ac_ = context.Operators.End(ab_);
				var ad_ = context.Operators.SameOrBefore(z_, ac_, null);
				var ae_ = context.Operators.And(v_, ad_);

				return ae_;
			};
			var k_ = context.Operators.Where<Condition>(i_, j_);
			Encounter l_(Condition AtrialFibrillationFlutter) => 
				IschemicStrokeEncounter;
			var m_ = context.Operators.Select<Condition, Encounter>(k_, l_);

			return m_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		bool? e_(Encounter IschemicStrokeEncounter)
		{
			var af_ = CQMCommon_2_0_000.encounterDiagnosis(IschemicStrokeEncounter);
			bool? ag_(Condition EncounterDiagnosis)
			{
				var aj_ = EncounterDiagnosis?.Code;
				var ak_ = FHIRHelpers_4_3_000.ToConcept(aj_);
				var al_ = this.Atrial_Fibrillation_or_Flutter();
				var am_ = context.Operators.ConceptInValueSet(ak_, al_);

				return am_;
			};
			var ah_ = context.Operators.Where<Condition>(af_, ag_);
			var ai_ = context.Operators.Exists<Condition>(ah_);

			return ai_;
		};
		var f_ = context.Operators.Where<Encounter>(a_, e_);
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
			var f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				Encounter;
			var h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

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
			var f_ = Encounter?.StatusElement;
			var g_ = f_?.Value;
			var h_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(g_);
			var i_ = context.Operators.Equal(h_, "finished");
			var j_ = Encounter?.Hospitalization;
			var k_ = j_?.DischargeDisposition;
			var l_ = FHIRHelpers_4_3_000.ToConcept(k_);
			var m_ = this.Discharge_To_Acute_Care_Facility();
			var n_ = context.Operators.ConceptInValueSet(l_, m_);
			var p_ = j_?.DischargeDisposition;
			var q_ = FHIRHelpers_4_3_000.ToConcept(p_);
			var r_ = this.Left_Against_Medical_Advice();
			var s_ = context.Operators.ConceptInValueSet(q_, r_);
			var t_ = context.Operators.Or(n_, s_);
			var v_ = j_?.DischargeDisposition;
			var w_ = FHIRHelpers_4_3_000.ToConcept(v_);
			var x_ = this.Patient_Expired();
			var y_ = context.Operators.ConceptInValueSet(w_, x_);
			var z_ = context.Operators.Or(t_, y_);
			var ab_ = j_?.DischargeDisposition;
			var ac_ = FHIRHelpers_4_3_000.ToConcept(ab_);
			var ad_ = this.Discharged_to_Home_for_Hospice_Care();
			var ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
			var af_ = context.Operators.Or(z_, ae_);
			var ah_ = j_?.DischargeDisposition;
			var ai_ = FHIRHelpers_4_3_000.ToConcept(ah_);
			var aj_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care();
			var ak_ = context.Operators.ConceptInValueSet(ai_, aj_);
			var al_ = context.Operators.Or(af_, ak_);
			var am_ = context.Operators.And(i_, al_);

			return am_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
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
				var p_ = DischargeAnticoagulant?.StatusElement;
				var q_ = p_?.Value;
				var r_ = context.Operators.Convert<string>(q_);
				var s_ = new string[]
				{
					"active",
					"completed",
				};
				var t_ = context.Operators.In<string>(r_, (s_ as IEnumerable<string>));
				var u_ = context.Operators.And(o_, t_);
				var v_ = DischargeAnticoagulant?.IntentElement;
				var w_ = v_?.Value;
				var x_ = context.Operators.Convert<string>(w_);
				var y_ = new string[]
				{
					"order",
					"original-order",
					"reflex-order",
					"filler-order",
					"instance-order",
				};
				var z_ = context.Operators.In<string>(x_, (y_ as IEnumerable<string>));
				var aa_ = context.Operators.And(u_, z_);
				var ab_ = DischargeAnticoagulant?.DoNotPerformElement;
				var ac_ = ab_?.Value;
				var ad_ = context.Operators.IsTrue(ac_);
				var ae_ = context.Operators.Not(ad_);
				var af_ = context.Operators.And(aa_, ae_);
				var ag_ = DischargeAnticoagulant?.AuthoredOnElement;
				var ah_ = context.Operators.Convert<CqlDateTime>(ag_);
				var ai_ = Encounter?.Period;
				var aj_ = FHIRHelpers_4_3_000.ToInterval(ai_);
				var ak_ = context.Operators.In<CqlDateTime>(ah_, aj_, null);
				var al_ = context.Operators.And(af_, ak_);

				return al_;
			};
			var j_ = context.Operators.Where<MedicationRequest>(h_, i_);
			Encounter k_(MedicationRequest DischargeAnticoagulant) => 
				Encounter;
			var l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

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
			var e_ = NoAnticoagulant?.ReasonCode;
			CqlConcept f_(CodeableConcept @this)
			{
				var z_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return z_;
			};
			var g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
			var h_ = this.Medical_Reason_For_Not_Providing_Treatment();
			var i_ = context.Operators.ConceptsInValueSet(g_, h_);
			CqlConcept k_(CodeableConcept @this)
			{
				var aa_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return aa_;
			};
			var l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, k_);
			var m_ = this.Patient_Refusal();
			var n_ = context.Operators.ConceptsInValueSet(l_, m_);
			var o_ = context.Operators.Or(i_, n_);
			var p_ = QICoreCommon_2_0_000.isCommunity(NoAnticoagulant);
			var q_ = QICoreCommon_2_0_000.isDischarge(NoAnticoagulant);
			var r_ = context.Operators.Or(p_, q_);
			var s_ = context.Operators.And(o_, r_);
			var t_ = NoAnticoagulant?.IntentElement;
			var u_ = t_?.Value;
			var v_ = context.Operators.Convert<string>(u_);
			var w_ = new string[]
			{
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			};
			var x_ = context.Operators.In<string>(v_, (w_ as IEnumerable<string>));
			var y_ = context.Operators.And(s_, x_);

			return y_;
		};
		var d_ = context.Operators.Where<MedicationRequest>(b_, c_);

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
				var i_ = NoDischargeAnticoagulant?.AuthoredOnElement;
				var j_ = context.Operators.Convert<CqlDateTime>(i_);
				var k_ = Encounter?.Period;
				var l_ = FHIRHelpers_4_3_000.ToInterval(k_);
				var m_ = context.Operators.In<CqlDateTime>(j_, l_, null);

				return m_;
			};
			var f_ = context.Operators.Where<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest NoDischargeAnticoagulant) => 
				Encounter;
			var h_ = context.Operators.Select<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

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
