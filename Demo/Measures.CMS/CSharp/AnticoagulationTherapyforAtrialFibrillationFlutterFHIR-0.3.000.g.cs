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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.200", default);

    [CqlDeclaration("Anticoagulant Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.200")]
	public CqlValueSet Anticoagulant_Therapy() => 
		__Anticoagulant_Therapy.Value;

	private CqlValueSet Atrial_Ablation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.203", default);

    [CqlDeclaration("Atrial Ablation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.203")]
	public CqlValueSet Atrial_Ablation() => 
		__Atrial_Ablation.Value;

	private CqlValueSet Atrial_Fibrillation_or_Flutter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202", default);

    [CqlDeclaration("Atrial Fibrillation or Flutter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202")]
	public CqlValueSet Atrial_Fibrillation_or_Flutter() => 
		__Atrial_Fibrillation_or_Flutter.Value;

	private CqlValueSet Discharge_To_Acute_Care_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", default);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility() => 
		__Discharge_To_Acute_Care_Facility.Value;

	private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", default);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => 
		__Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

	private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", default);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care() => 
		__Discharged_to_Home_for_Hospice_Care.Value;

	private CqlValueSet History_of_Atrial_Ablation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.76", default);

    [CqlDeclaration("History of Atrial Ablation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.76")]
	public CqlValueSet History_of_Atrial_Ablation() => 
		__History_of_Atrial_Ablation.Value;

	private CqlValueSet Left_Against_Medical_Advice_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", default);

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
	public CqlValueSet Left_Against_Medical_Advice() => 
		__Left_Against_Medical_Advice.Value;

	private CqlValueSet Medical_Reason_For_Not_Providing_Treatment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", default);

    [CqlDeclaration("Medical Reason For Not Providing Treatment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
	public CqlValueSet Medical_Reason_For_Not_Providing_Treatment() => 
		__Medical_Reason_For_Not_Providing_Treatment.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Patient_Refusal_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", default);

    [CqlDeclaration("Patient Refusal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93")]
	public CqlValueSet Patient_Refusal() => 
		__Patient_Refusal.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AnticoagulationTherapyforAtrialFibrillationFlutterFHIR-0.3.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Encounter_with_Principal_Diagnosis_and_Age();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Encounter_with_a_History_of_Atrial_Ablation_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		bool? b_(Encounter IschemicStrokeEncounter)
		{
			CqlValueSet l_ = this.Atrial_Ablation();
			IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			bool? n_(Procedure AtrialAblationProcedure)
			{
				Code<EventStatus> q_ = AtrialAblationProcedure?.StatusElement;
				EventStatus? r_ = q_?.Value;
				string s_ = context.Operators.Convert<string>(r_);
				bool? t_ = context.Operators.Equal(s_, "completed");
				DataType u_ = AtrialAblationProcedure?.Performed;
				object v_ = FHIRHelpers_4_3_000.ToValue(u_);
				CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.toInterval(v_);
				CqlDateTime x_ = context.Operators.Start(w_);
				Period y_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_3_000.ToInterval(y_);
				CqlDateTime aa_ = context.Operators.Start(z_);
				bool? ab_ = context.Operators.Before(x_, aa_, default);
				bool? ac_ = context.Operators.And(t_, ab_);

				return ac_;
			};
			IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);
			bool? p_ = context.Operators.Exists<Procedure>(o_);

			return p_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter IschemicStrokeEncounter)
		{
			CqlValueSet ad_ = this.History_of_Atrial_Ablation();
			IEnumerable<Condition> ae_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			bool? af_(Condition AtrialAblationDiagnosis)
			{
				CodeableConcept aj_ = AtrialAblationDiagnosis?.VerificationStatus;
				CqlConcept ak_ = FHIRHelpers_4_3_000.ToConcept(aj_);
				bool? al_ = context.Operators.Not((bool?)(ak_ is null));
				CqlConcept an_ = FHIRHelpers_4_3_000.ToConcept(aj_);
				CqlCode ao_ = QICoreCommon_2_0_000.confirmed();
				CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
				bool? aq_ = context.Operators.Equivalent(an_, ap_);
				bool? ar_ = context.Operators.And(al_, aq_);
				DataType as_ = AtrialAblationDiagnosis?.Onset;
				object at_ = FHIRHelpers_4_3_000.ToValue(as_);
				CqlInterval<CqlDateTime> au_ = QICoreCommon_2_0_000.toInterval(at_);
				CqlDateTime av_ = context.Operators.Start(au_);
				Period aw_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_3_000.ToInterval(aw_);
				CqlDateTime ay_ = context.Operators.Start(ax_);
				bool? az_ = context.Operators.Before(av_, ay_, default);
				bool? ba_ = context.Operators.And(ar_, az_);

				return ba_;
			};
			IEnumerable<Condition> ag_ = context.Operators.Where<Condition>(ae_, af_);
			Encounter ah_(Condition AtrialAblationDiagnosis) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> ai_ = context.Operators.Select<Condition, Encounter>(ag_, ah_);

			return ai_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
		IEnumerable<Encounter> i_(Encounter IschemicStrokeEncounter)
		{
			CqlValueSet bb_ = this.History_of_Atrial_Ablation();
			IEnumerable<Observation> bc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
			bool? bd_(Observation AtrialAblationObservation)
			{
				Code<ObservationStatus> bh_ = AtrialAblationObservation?.StatusElement;
				ObservationStatus? bi_ = bh_?.Value;
				Code<ObservationStatus> bj_ = context.Operators.Convert<Code<ObservationStatus>>(bi_);
				string bk_ = context.Operators.Convert<string>(bj_);
				string[] bl_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bm_ = context.Operators.In<string>(bk_, bl_ as IEnumerable<string>);
				object bn_()
				{
					bool bu_()
					{
						DataType bx_ = AtrialAblationObservation?.Effective;
						object by_ = FHIRHelpers_4_3_000.ToValue(bx_);
						bool bz_ = by_ is CqlDateTime;

						return bz_;
					};
					bool bv_()
					{
						DataType ca_ = AtrialAblationObservation?.Effective;
						object cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
						bool cc_ = cb_ is CqlInterval<CqlDateTime>;

						return cc_;
					};
					bool bw_()
					{
						DataType cd_ = AtrialAblationObservation?.Effective;
						object ce_ = FHIRHelpers_4_3_000.ToValue(cd_);
						bool cf_ = ce_ is CqlDateTime;

						return cf_;
					};
					if (bu_())
					{
						DataType cg_ = AtrialAblationObservation?.Effective;
						object ch_ = FHIRHelpers_4_3_000.ToValue(cg_);

						return (ch_ as CqlDateTime) as object;
					}
					else if (bv_())
					{
						DataType ci_ = AtrialAblationObservation?.Effective;
						object cj_ = FHIRHelpers_4_3_000.ToValue(ci_);

						return (cj_ as CqlInterval<CqlDateTime>) as object;
					}
					else if (bw_())
					{
						DataType ck_ = AtrialAblationObservation?.Effective;
						object cl_ = FHIRHelpers_4_3_000.ToValue(ck_);

						return (cl_ as CqlDateTime) as object;
					}
					else
					{
						return null;
					}
				};
				CqlDateTime bo_ = QICoreCommon_2_0_000.earliest(bn_());
				Period bp_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> bq_ = FHIRHelpers_4_3_000.ToInterval(bp_);
				CqlDateTime br_ = context.Operators.End(bq_);
				bool? bs_ = context.Operators.SameOrBefore(bo_, br_, default);
				bool? bt_ = context.Operators.And(bm_, bs_);

				return bt_;
			};
			IEnumerable<Observation> be_ = context.Operators.Where<Observation>(bc_, bd_);
			Encounter bf_(Observation AtrialAblationObservation) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> bg_ = context.Operators.Select<Observation, Encounter>(be_, bf_);

			return bg_;
		};
		IEnumerable<Encounter> j_ = context.Operators.SelectMany<Encounter, Encounter>(a_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(g_, j_);

		return k_;
	}

    [CqlDeclaration("Encounter with a History of Atrial Ablation")]
	public IEnumerable<Encounter> Encounter_with_a_History_of_Atrial_Ablation() => 
		__Encounter_with_a_History_of_Atrial_Ablation.Value;

	private IEnumerable<Encounter> Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			CqlValueSet h_ = this.Atrial_Fibrillation_or_Flutter();
			IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			bool? j_(Condition AtrialFibrillationFlutter)
			{
				CodeableConcept n_ = AtrialFibrillationFlutter?.VerificationStatus;
				CqlConcept o_ = FHIRHelpers_4_3_000.ToConcept(n_);
				bool? p_ = context.Operators.Not((bool?)(o_ is null));
				CqlConcept r_ = FHIRHelpers_4_3_000.ToConcept(n_);
				CqlCode s_ = QICoreCommon_2_0_000.confirmed();
				CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
				bool? u_ = context.Operators.Equivalent(r_, t_);
				bool? v_ = context.Operators.And(p_, u_);
				DataType w_ = AtrialFibrillationFlutter?.Onset;
				object x_ = FHIRHelpers_4_3_000.ToValue(w_);
				CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.toInterval(x_);
				CqlDateTime z_ = context.Operators.Start(y_);
				Period aa_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_3_000.ToInterval(aa_);
				CqlDateTime ac_ = context.Operators.End(ab_);
				bool? ad_ = context.Operators.SameOrBefore(z_, ac_, default);
				bool? ae_ = context.Operators.And(v_, ad_);

				return ae_;
			};
			IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
			Encounter l_(Condition AtrialFibrillationFlutter) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> m_ = context.Operators.Select<Condition, Encounter>(k_, l_);

			return m_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		bool? e_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<Condition> af_ = CQMCommon_2_0_000.encounterDiagnosis(IschemicStrokeEncounter);
			bool? ag_(Condition EncounterDiagnosis)
			{
				CodeableConcept aj_ = EncounterDiagnosis?.Code;
				CqlConcept ak_ = FHIRHelpers_4_3_000.ToConcept(aj_);
				CqlValueSet al_ = this.Atrial_Fibrillation_or_Flutter();
				bool? am_ = context.Operators.ConceptInValueSet(ak_, al_);

				return am_;
			};
			IEnumerable<Condition> ah_ = context.Operators.Where<Condition>(af_, ag_);
			bool? ai_ = context.Operators.Exists<Condition>(ah_);

			return ai_;
		};
		IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
		IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

		return g_;
	}

    [CqlDeclaration("Encounter with Prior or Present Diagnosis of Atrial Fibrillation or Flutter")]
	public IEnumerable<Encounter> Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter() => 
		__Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_a_History_of_Atrial_Ablation();
		IEnumerable<Encounter> b_ = this.Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter_Value()
	{
		IEnumerable<Encounter> a_ = this.Denominator();
		IEnumerable<Encounter> b_(Encounter Encounter)
		{
			IEnumerable<object> d_ = TJCOverall_8_11_000.Intervention_Comfort_Measures();
			bool? e_(object ComfortMeasure)
			{
				object i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				object j_ = FHIRHelpers_4_3_000.ToValue(i_);
				CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.toInterval(j_);
				CqlDateTime l_ = context.Operators.Start(k_);
				object m_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
				CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
				CqlInterval<CqlDateTime> o_ = CQMCommon_2_0_000.hospitalizationWithObservation(Encounter);
				bool? p_ = context.Operators.In<CqlDateTime>(l_ ?? n_, o_, default);

				return p_;
			};
			IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				Encounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization for Patients with Documented Atrial Fibrillation or Flutter")]
	public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter() => 
		__Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		IEnumerable<Encounter> a_ = this.Denominator();
		bool? b_(Encounter Encounter)
		{
			Code<Encounter.EncounterStatus> f_ = Encounter?.StatusElement;
			Encounter.EncounterStatus? g_ = f_?.Value;
			Code<Encounter.EncounterStatus> h_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(g_);
			bool? i_ = context.Operators.Equal(h_, "finished");
			Encounter.HospitalizationComponent j_ = Encounter?.Hospitalization;
			CodeableConcept k_ = j_?.DischargeDisposition;
			CqlConcept l_ = FHIRHelpers_4_3_000.ToConcept(k_);
			CqlValueSet m_ = this.Discharge_To_Acute_Care_Facility();
			bool? n_ = context.Operators.ConceptInValueSet(l_, m_);
			CodeableConcept p_ = j_?.DischargeDisposition;
			CqlConcept q_ = FHIRHelpers_4_3_000.ToConcept(p_);
			CqlValueSet r_ = this.Left_Against_Medical_Advice();
			bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
			bool? t_ = context.Operators.Or(n_, s_);
			CodeableConcept v_ = j_?.DischargeDisposition;
			CqlConcept w_ = FHIRHelpers_4_3_000.ToConcept(v_);
			CqlValueSet x_ = this.Patient_Expired();
			bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
			bool? z_ = context.Operators.Or(t_, y_);
			CodeableConcept ab_ = j_?.DischargeDisposition;
			CqlConcept ac_ = FHIRHelpers_4_3_000.ToConcept(ab_);
			CqlValueSet ad_ = this.Discharged_to_Home_for_Hospice_Care();
			bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
			bool? af_ = context.Operators.Or(z_, ae_);
			CodeableConcept ah_ = j_?.DischargeDisposition;
			CqlConcept ai_ = FHIRHelpers_4_3_000.ToConcept(ah_);
			CqlValueSet aj_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care();
			bool? ak_ = context.Operators.ConceptInValueSet(ai_, aj_);
			bool? al_ = context.Operators.Or(af_, ak_);
			bool? am_ = context.Operators.And(i_, al_);

			return am_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter();
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Denominator();
		IEnumerable<Encounter> b_(Encounter Encounter)
		{
			CqlValueSet d_ = this.Anticoagulant_Therapy();
			IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
			bool? i_(MedicationRequest DischargeAnticoagulant)
			{
				bool? m_ = QICoreCommon_2_0_000.isCommunity(DischargeAnticoagulant);
				bool? n_ = QICoreCommon_2_0_000.isDischarge(DischargeAnticoagulant);
				bool? o_ = context.Operators.Or(m_, n_);
				Code<MedicationRequest.MedicationrequestStatus> p_ = DischargeAnticoagulant?.StatusElement;
				MedicationRequest.MedicationrequestStatus? q_ = p_?.Value;
				string r_ = context.Operators.Convert<string>(q_);
				string[] s_ = [
					"active",
					"completed",
				];
				bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
				bool? u_ = context.Operators.And(o_, t_);
				Code<MedicationRequest.MedicationRequestIntent> v_ = DischargeAnticoagulant?.IntentElement;
				MedicationRequest.MedicationRequestIntent? w_ = v_?.Value;
				string x_ = context.Operators.Convert<string>(w_);
				string[] y_ = [
					"order",
					"original-order",
					"reflex-order",
					"filler-order",
					"instance-order",
				];
				bool? z_ = context.Operators.In<string>(x_, y_ as IEnumerable<string>);
				bool? aa_ = context.Operators.And(u_, z_);
				FhirBoolean ab_ = DischargeAnticoagulant?.DoNotPerformElement;
				bool? ac_ = ab_?.Value;
				bool? ad_ = context.Operators.IsTrue(ac_);
				bool? ae_ = context.Operators.Not(ad_);
				bool? af_ = context.Operators.And(aa_, ae_);
				FhirDateTime ag_ = DischargeAnticoagulant?.AuthoredOnElement;
				CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(ag_);
				Period ai_ = Encounter?.Period;
				CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(ai_);
				bool? ak_ = context.Operators.In<CqlDateTime>(ah_, aj_, default);
				bool? al_ = context.Operators.And(af_, ak_);

				return al_;
			};
			IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
			Encounter k_(MedicationRequest DischargeAnticoagulant) => 
				Encounter;
			IEnumerable<Encounter> l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<MedicationRequest> Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge_Value()
	{
		CqlValueSet a_ = this.Anticoagulant_Therapy();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
		bool? c_(MedicationRequest NoAnticoagulant)
		{
			List<CodeableConcept> e_ = NoAnticoagulant?.ReasonCode;
			CqlConcept f_(CodeableConcept @this)
			{
				CqlConcept z_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return z_;
			};
			IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
			CqlValueSet h_ = this.Medical_Reason_For_Not_Providing_Treatment();
			bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
			CqlConcept k_(CodeableConcept @this)
			{
				CqlConcept aa_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return aa_;
			};
			IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, k_);
			CqlValueSet m_ = this.Patient_Refusal();
			bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
			bool? o_ = context.Operators.Or(i_, n_);
			bool? p_ = QICoreCommon_2_0_000.isCommunity(NoAnticoagulant);
			bool? q_ = QICoreCommon_2_0_000.isDischarge(NoAnticoagulant);
			bool? r_ = context.Operators.Or(p_, q_);
			bool? s_ = context.Operators.And(o_, r_);
			Code<MedicationRequest.MedicationRequestIntent> t_ = NoAnticoagulant?.IntentElement;
			MedicationRequest.MedicationRequestIntent? u_ = t_?.Value;
			string v_ = context.Operators.Convert<string>(u_);
			string[] w_ = [
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			];
			bool? x_ = context.Operators.In<string>(v_, w_ as IEnumerable<string>);
			bool? y_ = context.Operators.And(s_, x_);

			return y_;
		};
		IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Documented Reason for Not Giving Anticoagulant at Discharge")]
	public IEnumerable<MedicationRequest> Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge() => 
		__Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		IEnumerable<Encounter> a_ = this.Denominator();
		IEnumerable<Encounter> b_(Encounter Encounter)
		{
			IEnumerable<MedicationRequest> d_ = this.Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge();
			bool? e_(MedicationRequest NoDischargeAnticoagulant)
			{
				FhirDateTime i_ = NoDischargeAnticoagulant?.AuthoredOnElement;
				CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
				Period k_ = Encounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_);
				bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, default);

				return m_;
			};
			IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest NoDischargeAnticoagulant) => 
				Encounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

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
