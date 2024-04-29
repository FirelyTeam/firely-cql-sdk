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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
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
			IEnumerable<Procedure> m_ = context.Operators.RetrieveByValueSet<Procedure>(l_, null);
			bool? n_(Procedure AtrialAblationProcedure)
			{
				string q_ = context.Operators.Convert<string>(AtrialAblationProcedure?.StatusElement?.Value);
				bool? r_ = context.Operators.Equal(q_, "completed");
				object s_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationProcedure?.Performed);
				CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.toInterval(s_);
				CqlDateTime u_ = context.Operators.Start(t_);
				CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.ToInterval(IschemicStrokeEncounter?.Period);
				CqlDateTime w_ = context.Operators.Start(v_);
				bool? x_ = context.Operators.Before(u_, w_, null);
				bool? y_ = context.Operators.And(r_, x_);

				return y_;
			};
			IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);
			bool? p_ = context.Operators.Exists<Procedure>(o_);

			return p_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter IschemicStrokeEncounter)
		{
			CqlValueSet z_ = this.History_of_Atrial_Ablation();
			IEnumerable<Condition> aa_ = context.Operators.RetrieveByValueSet<Condition>(z_, null);
			bool? ab_(Condition AtrialAblationDiagnosis)
			{
				CqlConcept af_ = FHIRHelpers_4_3_000.ToConcept(AtrialAblationDiagnosis?.VerificationStatus);
				bool? ag_ = context.Operators.Not((bool?)(af_ is null));
				CqlCode ai_ = QICoreCommon_2_0_000.confirmed();
				CqlConcept aj_ = context.Operators.ConvertCodeToConcept(ai_);
				bool? ak_ = context.Operators.Equivalent(af_, aj_);
				bool? al_ = context.Operators.And(ag_, ak_);
				object am_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationDiagnosis?.Onset);
				CqlInterval<CqlDateTime> an_ = QICoreCommon_2_0_000.toInterval(am_);
				CqlDateTime ao_ = context.Operators.Start(an_);
				CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_3_000.ToInterval(IschemicStrokeEncounter?.Period);
				CqlDateTime aq_ = context.Operators.Start(ap_);
				bool? ar_ = context.Operators.Before(ao_, aq_, null);
				bool? as_ = context.Operators.And(al_, ar_);

				return as_;
			};
			IEnumerable<Condition> ac_ = context.Operators.Where<Condition>(aa_, ab_);
			Encounter ad_(Condition AtrialAblationDiagnosis) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> ae_ = context.Operators.Select<Condition, Encounter>(ac_, ad_);

			return ae_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_ = context.Operators.ListUnion<Encounter>(c_, f_);
		IEnumerable<Encounter> i_(Encounter IschemicStrokeEncounter)
		{
			CqlValueSet at_ = this.History_of_Atrial_Ablation();
			IEnumerable<Observation> au_ = context.Operators.RetrieveByValueSet<Observation>(at_, null);
			bool? av_(Observation AtrialAblationObservation)
			{
				Code<ObservationStatus> az_ = context.Operators.Convert<Code<ObservationStatus>>(AtrialAblationObservation?.StatusElement?.Value);
				string ba_ = context.Operators.Convert<string>(az_);
				string[] bb_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? bc_ = context.Operators.In<string>(ba_, (bb_ as IEnumerable<string>));
				object bd_()
				{
					bool bj_()
					{
						object bm_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationObservation?.Effective);
						bool bn_ = bm_ is CqlDateTime;

						return bn_;
					};
					bool bk_()
					{
						object bo_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationObservation?.Effective);
						bool bp_ = bo_ is CqlInterval<CqlDateTime>;

						return bp_;
					};
					bool bl_()
					{
						object bq_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationObservation?.Effective);
						bool br_ = bq_ is CqlDateTime;

						return br_;
					};
					if (bj_())
					{
						object bs_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationObservation?.Effective);

						return ((bs_ as CqlDateTime) as object);
					}
					else if (bk_())
					{
						object bt_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationObservation?.Effective);

						return ((bt_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (bl_())
					{
						object bu_ = FHIRHelpers_4_3_000.ToValue(AtrialAblationObservation?.Effective);

						return ((bu_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				CqlDateTime be_ = QICoreCommon_2_0_000.earliest(bd_());
				CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_3_000.ToInterval(IschemicStrokeEncounter?.Period);
				CqlDateTime bg_ = context.Operators.End(bf_);
				bool? bh_ = context.Operators.SameOrBefore(be_, bg_, null);
				bool? bi_ = context.Operators.And(bc_, bh_);

				return bi_;
			};
			IEnumerable<Observation> aw_ = context.Operators.Where<Observation>(au_, av_);
			Encounter ax_(Observation AtrialAblationObservation) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> ay_ = context.Operators.Select<Observation, Encounter>(aw_, ax_);

			return ay_;
		};
		IEnumerable<Encounter> j_ = context.Operators.SelectMany<Encounter, Encounter>(a_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(g_, j_);

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
			IEnumerable<Condition> i_ = context.Operators.RetrieveByValueSet<Condition>(h_, null);
			bool? j_(Condition AtrialFibrillationFlutter)
			{
				CqlConcept n_ = FHIRHelpers_4_3_000.ToConcept(AtrialFibrillationFlutter?.VerificationStatus);
				bool? o_ = context.Operators.Not((bool?)(n_ is null));
				CqlCode q_ = QICoreCommon_2_0_000.confirmed();
				CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
				bool? s_ = context.Operators.Equivalent(n_, r_);
				bool? t_ = context.Operators.And(o_, s_);
				object u_ = FHIRHelpers_4_3_000.ToValue(AtrialFibrillationFlutter?.Onset);
				CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.toInterval(u_);
				CqlDateTime w_ = context.Operators.Start(v_);
				CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(IschemicStrokeEncounter?.Period);
				CqlDateTime y_ = context.Operators.End(x_);
				bool? z_ = context.Operators.SameOrBefore(w_, y_, null);
				bool? aa_ = context.Operators.And(t_, z_);

				return aa_;
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
			IEnumerable<Condition> ab_ = CQMCommon_2_0_000.encounterDiagnosis(IschemicStrokeEncounter);
			bool? ac_(Condition EncounterDiagnosis)
			{
				CqlConcept af_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				CqlValueSet ag_ = this.Atrial_Fibrillation_or_Flutter();
				bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);

				return ah_;
			};
			IEnumerable<Condition> ad_ = context.Operators.Where<Condition>(ab_, ac_);
			bool? ae_ = context.Operators.Exists<Condition>(ad_);

			return ae_;
		};
		IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
		IEnumerable<Encounter> g_ = context.Operators.ListUnion<Encounter>(c_, f_);

		return g_;
	}

    [CqlDeclaration("Encounter with Prior or Present Diagnosis of Atrial Fibrillation or Flutter")]
	public IEnumerable<Encounter> Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter() => 
		__Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_a_History_of_Atrial_Ablation();
		IEnumerable<Encounter> b_ = this.Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter();
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);

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
				bool? p_ = context.Operators.In<CqlDateTime>((l_ ?? n_), o_, null);

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
			Code<Encounter.EncounterStatus> f_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(Encounter?.StatusElement?.Value);
			bool? g_ = context.Operators.Equal(f_, "finished");
			CqlConcept h_ = FHIRHelpers_4_3_000.ToConcept(Encounter?.Hospitalization?.DischargeDisposition);
			CqlValueSet i_ = this.Discharge_To_Acute_Care_Facility();
			bool? j_ = context.Operators.ConceptInValueSet(h_, i_);
			CqlValueSet l_ = this.Left_Against_Medical_Advice();
			bool? m_ = context.Operators.ConceptInValueSet(h_, l_);
			bool? n_ = context.Operators.Or(j_, m_);
			CqlValueSet p_ = this.Patient_Expired();
			bool? q_ = context.Operators.ConceptInValueSet(h_, p_);
			bool? r_ = context.Operators.Or(n_, q_);
			CqlValueSet t_ = this.Discharged_to_Home_for_Hospice_Care();
			bool? u_ = context.Operators.ConceptInValueSet(h_, t_);
			bool? v_ = context.Operators.Or(r_, u_);
			CqlValueSet x_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care();
			bool? y_ = context.Operators.ConceptInValueSet(h_, x_);
			bool? z_ = context.Operators.Or(v_, y_);
			bool? aa_ = context.Operators.And(g_, z_);

			return aa_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter();
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(c_, d_);

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
			IEnumerable<MedicationRequest> e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			IEnumerable<MedicationRequest> g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			IEnumerable<MedicationRequest> h_ = context.Operators.ListUnion<MedicationRequest>(e_, g_);
			bool? i_(MedicationRequest DischargeAnticoagulant)
			{
				bool? m_ = QICoreCommon_2_0_000.isCommunity(DischargeAnticoagulant);
				bool? n_ = QICoreCommon_2_0_000.isDischarge(DischargeAnticoagulant);
				bool? o_ = context.Operators.Or(m_, n_);
				string p_ = context.Operators.Convert<string>(DischargeAnticoagulant?.StatusElement?.Value);
				string[] q_ = new string[]
				{
					"active",
					"completed",
				};
				bool? r_ = context.Operators.In<string>(p_, (q_ as IEnumerable<string>));
				bool? s_ = context.Operators.And(o_, r_);
				string t_ = context.Operators.Convert<string>(DischargeAnticoagulant?.IntentElement?.Value);
				string[] u_ = new string[]
				{
					"order",
					"original-order",
					"reflex-order",
					"filler-order",
					"instance-order",
				};
				bool? v_ = context.Operators.In<string>(t_, (u_ as IEnumerable<string>));
				bool? w_ = context.Operators.And(s_, v_);
				bool? x_ = context.Operators.IsTrue(DischargeAnticoagulant?.DoNotPerformElement?.Value);
				bool? y_ = context.Operators.Not(x_);
				bool? z_ = context.Operators.And(w_, y_);
				CqlDateTime aa_ = context.Operators.Convert<CqlDateTime>(DischargeAnticoagulant?.AuthoredOnElement);
				CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_3_000.ToInterval(Encounter?.Period);
				bool? ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, null);
				bool? ad_ = context.Operators.And(z_, ac_);

				return ad_;
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
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		bool? c_(MedicationRequest NoAnticoagulant)
		{
			CqlConcept e_(CodeableConcept @this)
			{
				CqlConcept v_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return v_;
			};
			IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>(NoAnticoagulant?.ReasonCode, e_);
			CqlValueSet g_ = this.Medical_Reason_For_Not_Providing_Treatment();
			bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
			CqlConcept i_(CodeableConcept @this)
			{
				CqlConcept w_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return w_;
			};
			IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>(NoAnticoagulant?.ReasonCode, i_);
			CqlValueSet k_ = this.Patient_Refusal();
			bool? l_ = context.Operators.ConceptsInValueSet(j_, k_);
			bool? m_ = context.Operators.Or(h_, l_);
			bool? n_ = QICoreCommon_2_0_000.isCommunity(NoAnticoagulant);
			bool? o_ = QICoreCommon_2_0_000.isDischarge(NoAnticoagulant);
			bool? p_ = context.Operators.Or(n_, o_);
			bool? q_ = context.Operators.And(m_, p_);
			string r_ = context.Operators.Convert<string>(NoAnticoagulant?.IntentElement?.Value);
			string[] s_ = new string[]
			{
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			};
			bool? t_ = context.Operators.In<string>(r_, (s_ as IEnumerable<string>));
			bool? u_ = context.Operators.And(q_, t_);

			return u_;
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
				CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(NoDischargeAnticoagulant?.AuthoredOnElement);
				CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.ToInterval(Encounter?.Period);
				bool? k_ = context.Operators.In<CqlDateTime>(i_, j_, null);

				return k_;
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
