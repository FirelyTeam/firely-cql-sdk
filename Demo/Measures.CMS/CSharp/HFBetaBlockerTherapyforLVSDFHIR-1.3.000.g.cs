using System;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("HFBetaBlockerTherapyforLVSDFHIR", "1.3.000")]
public partial class HFBetaBlockerTherapyforLVSDFHIR_1_3_000
{
    private HFBetaBlockerTherapyforLVSDFHIR_1_3_000() {}

    public static HFBetaBlockerTherapyforLVSDFHIR_1_3_000 Instance { get; } = new();


    [CqlDeclaration("Allergy to Beta Blocker Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177")]
	public CqlValueSet Allergy_to_Beta_Blocker_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177", default);


    [CqlDeclaration("Arrhythmia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366")]
	public CqlValueSet Arrhythmia(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366", default);


    [CqlDeclaration("Asthma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362")]
	public CqlValueSet Asthma(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362", default);


    [CqlDeclaration("Atrioventricular Block")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367")]
	public CqlValueSet Atrioventricular_Block(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367", default);


    [CqlDeclaration("Beta Blocker Therapy for LVSD")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184")]
	public CqlValueSet Beta_Blocker_Therapy_for_LVSD(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184", default);


    [CqlDeclaration("Beta Blocker Therapy Ingredient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493")]
	public CqlValueSet Beta_Blocker_Therapy_Ingredient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493", default);


    [CqlDeclaration("Bradycardia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412")]
	public CqlValueSet Bradycardia(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412", default);


    [CqlDeclaration("Cardiac Pacer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53")]
	public CqlValueSet Cardiac_Pacer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53", default);


    [CqlDeclaration("Cardiac Pacer in Situ")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368")]
	public CqlValueSet Cardiac_Pacer_in_Situ(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368", default);


    [CqlDeclaration("Hypotension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370")]
	public CqlValueSet Hypotension(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370", default);


    [CqlDeclaration("Intolerance to Beta Blocker Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178")]
	public CqlValueSet Intolerance_to_Beta_Blocker_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178", default);


    [CqlDeclaration("Left Ventricular Assist Device Placement")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61")]
	public CqlValueSet Left_Ventricular_Assist_Device_Placement(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61", default);


    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", default);


    [CqlDeclaration("Patient Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008")]
	public CqlValueSet Patient_Reason(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", default);


    [CqlDeclaration("Substance with beta adrenergic receptor antagonist mechanism of action (substance)")]
	public CqlCode Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(CqlContext context) => 
		new CqlCode("373254001", "http://snomed.info/sct", default, default);


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("373254001", "http://snomed.info/sct", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HFBetaBlockerTherapyforLVSDFHIR-1.3.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
		IEnumerable<Encounter> j_ = AHAOverall_2_6_000.Instance.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
		int? k_ = context.Operators.Count<Encounter>(j_);
		bool? l_ = context.Operators.GreaterOrEqual(k_, 2);
		bool? m_ = context.Operators.And(i_, l_);
		IEnumerable<Encounter> n_ = AHAOverall_2_6_000.Instance.Heart_Failure_Outpatient_Encounter(context);
		bool? o_ = context.Operators.Exists<Encounter>(n_);
		bool? p_ = context.Operators.And(m_, o_);

		return p_;
	}


    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);
		IEnumerable<Encounter> b_ = AHAOverall_2_6_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
		bool? c_ = context.Operators.Exists<Encounter>(b_);
		bool? d_ = context.Operators.And(a_, c_);

		return d_;
	}


    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = AHAOverall_2_6_000.Instance.Has_Heart_Transplant(context);
		bool? b_ = AHAOverall_2_6_000.Instance.Has_Heart_Transplant_Complications(context);
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = AHAOverall_2_6_000.Instance.Has_Left_Ventricular_Assist_Device(context);
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = AHAOverall_2_6_000.Instance.Has_Left_Ventricular_Assist_Device_Complications(context);
		bool? g_ = context.Operators.Or(e_, f_);

		return g_;
	}


    [CqlDeclaration("Has Beta Blocker Therapy for LVSD Ordered")]
	public bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered(CqlContext context)
	{
		CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest BetaBlockerOrdered)
		{
			bool? i_ = AHAOverall_2_6_000.Instance.isOrderedDuringHeartFailureOutpatientEncounter(context, BetaBlockerOrdered);
			Code<MedicationRequest.MedicationrequestStatus> j_ = BetaBlockerOrdered?.StatusElement;
			MedicationRequest.MedicationrequestStatus? k_ = j_?.Value;
			string l_ = context.Operators.Convert<string>(k_);
			string[] m_ = [
				"active",
				"completed",
			];
			bool? n_ = context.Operators.In<string>(l_, m_ as IEnumerable<string>);
			bool? o_ = context.Operators.And(i_, n_);
			Code<MedicationRequest.MedicationRequestIntent> p_ = BetaBlockerOrdered?.IntentElement;
			MedicationRequest.MedicationRequestIntent? q_ = p_?.Value;
			string r_ = context.Operators.Convert<string>(q_);
			string[] s_ = [
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			];
			bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
			bool? u_ = context.Operators.And(o_, t_);

			return u_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);
		bool? h_ = context.Operators.Exists<MedicationRequest>(g_);

		return h_;
	}


    [CqlDeclaration("Is Currently Taking Beta Blocker Therapy for LVSD")]
	public bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(CqlContext context)
	{
		CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest ActiveBetaBlocker)
		{
			bool? i_ = AHAOverall_2_6_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ActiveBetaBlocker as object);

			return i_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);
		bool? h_ = context.Operators.Exists<MedicationRequest>(g_);

		return h_;
	}


    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		bool? a_ = this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered(context);
		bool? b_ = this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(context);
		bool? c_ = context.Operators.Or(a_, b_);

		return c_;
	}


    [CqlDeclaration("Has Consecutive Heart Rates Less than 50")]
	public bool? Has_Consecutive_Heart_Rates_Less_than_50(CqlContext context)
	{
		IEnumerable<Observation> a_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
		IEnumerable<Encounter> b_ = AHAOverall_2_6_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
		IEnumerable<ValueTuple<Observation, Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);
		(Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? d_(ValueTuple<Observation, Encounter> _valueTuple)
		{
			(Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> e_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(c_, d_);
		bool? f_((Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf)
		{
			Period l_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, l_);
			DataType n_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
			object o_ = FHIRHelpers_4_3_000.Instance.ToValue(context, n_);
			CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.Instance.toInterval(context, o_);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, default);
			Code<ObservationStatus> r_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.StatusElement;
			ObservationStatus? s_ = r_?.Value;
			string t_ = context.Operators.Convert<string>(s_);
			string[] u_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? v_ = context.Operators.In<string>(t_, u_ as IEnumerable<string>);
			bool? w_ = context.Operators.And(q_, v_);
			DataType x_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Value;
			CqlQuantity y_ = FHIRHelpers_4_3_000.Instance.ToQuantity(context, x_ as Quantity);
			CqlQuantity z_ = context.Operators.Quantity(50m, "/min");
			bool? aa_ = context.Operators.Less(y_, z_);
			bool? ab_ = context.Operators.And(w_, aa_);
			IEnumerable<Observation> ac_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? ad_(Observation MostRecentPriorHeartRate)
			{
				Period an_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, an_);
				DataType ap_ = MostRecentPriorHeartRate?.Effective;
				object aq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ap_);
				CqlInterval<CqlDateTime> ar_ = QICoreCommon_2_0_000.Instance.toInterval(context, aq_);
				bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ar_, default);
				object au_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ap_);
				CqlInterval<CqlDateTime> av_ = QICoreCommon_2_0_000.Instance.toInterval(context, au_);
				DataType aw_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
				object ax_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aw_);
				CqlInterval<CqlDateTime> ay_ = QICoreCommon_2_0_000.Instance.toInterval(context, ax_);
				bool? az_ = context.Operators.Before(av_, ay_, default);
				bool? ba_ = context.Operators.And(as_, az_);

				return ba_;
			};
			IEnumerable<Observation> ae_ = context.Operators.Where<Observation>(ac_, ad_);
			object af_(Observation @this)
			{
				DataType bb_ = @this?.Effective;
				object bc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bb_);
				CqlInterval<CqlDateTime> bd_ = QICoreCommon_2_0_000.Instance.toInterval(context, bc_);
				CqlDateTime be_ = context.Operators.Start(bd_);

				return be_;
			};
			IEnumerable<Observation> ag_ = context.Operators.SortBy<Observation>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
			Observation ah_ = context.Operators.Last<Observation>(ag_);
			DataType ai_ = ah_?.Value;
			CqlQuantity aj_ = FHIRHelpers_4_3_000.Instance.ToQuantity(context, ai_ as Quantity);
			bool? al_ = context.Operators.Less(aj_, z_);
			bool? am_ = context.Operators.And(ab_, al_);

			return am_;
		};
		IEnumerable<(Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> g_ = context.Operators.Where<(Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(e_, f_);
		Observation h_((Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf) => 
			tuple_fufpmqdratbglhghdwfuubanf?.HeartRate;
		IEnumerable<Observation> i_ = context.Operators.Select<(Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?, Observation>(g_, h_);
		bool? j_ = context.Operators.Exists<Observation>(i_);

		return j_;
	}


    [CqlDeclaration("Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD")]
	public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(CqlContext context)
	{
		IEnumerable<MedicationRequest> a_ = context.Operators.RetrieveByValueSet<MedicationRequest>(default, default);
		IEnumerable<MedicationRequest> b_(MedicationRequest NoBetaBlockerOrdered)
		{
			IEnumerable<Encounter> g_ = AHAOverall_2_6_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
			bool? h_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				FhirDateTime l_ = NoBetaBlockerOrdered?.AuthoredOnElement;
				CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
				Period n_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, n_);
				bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, default);

				return p_;
			};
			IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
			MedicationRequest j_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				NoBetaBlockerOrdered;
			IEnumerable<MedicationRequest> k_ = context.Operators.Select<Encounter, MedicationRequest>(i_, j_);

			return k_;
		};
		IEnumerable<MedicationRequest> c_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(a_, b_);
		bool? d_(MedicationRequest NoBetaBlockerOrdered)
		{
			DataType q_ = NoBetaBlockerOrdered?.Medication;
			CqlConcept r_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, q_ as CodeableConcept);
			CqlValueSet s_ = this.Beta_Blocker_Therapy_for_LVSD(context);
			bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
			List<CodeableConcept> u_ = NoBetaBlockerOrdered?.ReasonCode;
			CqlConcept v_(CodeableConcept @this)
			{
				CqlConcept ag_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return ag_;
			};
			IEnumerable<CqlConcept> w_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)u_, v_);
			CqlValueSet x_ = this.Medical_Reason(context);
			bool? y_ = context.Operators.ConceptsInValueSet(w_, x_);
			CqlConcept aa_(CodeableConcept @this)
			{
				CqlConcept ah_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return ah_;
			};
			IEnumerable<CqlConcept> ab_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)u_, aa_);
			CqlValueSet ac_ = this.Patient_Reason(context);
			bool? ad_ = context.Operators.ConceptsInValueSet(ab_, ac_);
			bool? ae_ = context.Operators.Or(y_, ad_);
			bool? af_ = context.Operators.And(t_, ae_);

			return af_;
		};
		IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
		bool? f_ = context.Operators.Exists<MedicationRequest>(e_);

		return f_;
	}


    [CqlDeclaration("Has Arrhythmia Diagnosis")]
	public bool? Has_Arrhythmia_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Arrhythmia(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition Arrhythmia)
		{
			bool? f_ = AHAOverall_2_6_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Arrhythmia);
			bool? g_ = QICoreCommon_2_0_000.Instance.isActive(context, Arrhythmia);
			bool? h_ = context.Operators.And(f_, g_);
			CodeableConcept i_ = Arrhythmia?.VerificationStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, i_);
			CqlCode k_ = QICoreCommon_2_0_000.Instance.confirmed(context);
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Has Hypotension Diagnosis")]
	public bool? Has_Hypotension_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Hypotension(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition Hypotension)
		{
			bool? f_ = AHAOverall_2_6_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Hypotension);
			bool? g_ = QICoreCommon_2_0_000.Instance.isActive(context, Hypotension);
			bool? h_ = context.Operators.And(f_, g_);
			CodeableConcept i_ = Hypotension?.VerificationStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, i_);
			CqlCode k_ = QICoreCommon_2_0_000.Instance.confirmed(context);
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Has Asthma Diagnosis")]
	public bool? Has_Asthma_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Asthma(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition Asthma)
		{
			bool? f_ = AHAOverall_2_6_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Asthma);
			bool? g_ = QICoreCommon_2_0_000.Instance.isActive(context, Asthma);
			bool? h_ = context.Operators.And(f_, g_);
			CodeableConcept i_ = Asthma?.VerificationStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, i_);
			CqlCode k_ = QICoreCommon_2_0_000.Instance.confirmed(context);
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy")]
	public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(CqlContext context)
	{
		CqlValueSet a_ = this.Allergy_to_Beta_Blocker_Therapy(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		CqlValueSet c_ = this.Intolerance_to_Beta_Blocker_Therapy(context);
		IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(c_, default);
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		bool? f_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis)
		{
			bool? i_ = AHAOverall_2_6_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis as object);
			bool? j_ = QICoreCommon_2_0_000.Instance.isActive(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
			bool? k_ = context.Operators.And(i_, j_);
			CodeableConcept l_ = BetaBlockerAllergyOrIntoleranceDiagnosis?.VerificationStatus;
			CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, l_);
			CqlCode n_ = QICoreCommon_2_0_000.Instance.confirmed(context);
			CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
			bool? p_ = context.Operators.Equivalent(m_, o_);
			bool? q_ = context.Operators.And(k_, p_);

			return q_;
		};
		IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
		bool? h_ = context.Operators.Exists<Condition>(g_);

		return h_;
	}


    [CqlDeclaration("Has Bradycardia Diagnosis")]
	public bool? Has_Bradycardia_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Bradycardia(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition Bradycardia)
		{
			bool? f_ = AHAOverall_2_6_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Bradycardia);
			bool? g_ = QICoreCommon_2_0_000.Instance.isActive(context, Bradycardia);
			bool? h_ = context.Operators.And(f_, g_);
			CodeableConcept i_ = Bradycardia?.VerificationStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, i_);
			CqlCode k_ = QICoreCommon_2_0_000.Instance.confirmed(context);
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Has Allergy or Intolerance to Beta Blocker Therapy Ingredient")]
	public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(CqlContext context)
	{
		CqlValueSet a_ = this.Beta_Blocker_Therapy_Ingredient(context);
		IEnumerable<AllergyIntolerance> b_ = context.Operators.RetrieveByValueSet<AllergyIntolerance>(a_, default);
		CqlCode c_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(context);
		IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
		IEnumerable<AllergyIntolerance> e_ = context.Operators.RetrieveByCodes<AllergyIntolerance>(d_, default);
		IEnumerable<AllergyIntolerance> f_ = context.Operators.Union<AllergyIntolerance>(b_, e_);
		bool? g_(AllergyIntolerance BetaBlockerAllergyIntolerance)
		{
			bool? j_ = AHAOverall_2_6_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyIntolerance as object);
			CodeableConcept k_ = BetaBlockerAllergyIntolerance?.ClinicalStatus;
			CqlConcept l_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, k_);
			CqlConcept n_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, k_);
			CqlCode o_ = QICoreCommon_2_0_000.Instance.allergy_active(context);
			CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
			bool? q_ = context.Operators.Equivalent(n_, p_);
			bool? r_ = context.Operators.Or((bool?)(l_ is null), q_);
			bool? s_ = context.Operators.And(j_, r_);

			return s_;
		};
		IEnumerable<AllergyIntolerance> h_ = context.Operators.Where<AllergyIntolerance>(f_, g_);
		bool? i_ = context.Operators.Exists<AllergyIntolerance>(h_);

		return i_;
	}


    [CqlDeclaration("Has Atrioventricular Block Diagnosis")]
	public bool? Has_Atrioventricular_Block_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Atrioventricular_Block(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition AtrioventricularBlock)
		{
			bool? f_ = AHAOverall_2_6_000.Instance.overlapsHeartFailureOutpatientEncounter(context, AtrioventricularBlock);
			bool? g_ = QICoreCommon_2_0_000.Instance.isActive(context, AtrioventricularBlock);
			bool? h_ = context.Operators.And(f_, g_);
			CodeableConcept i_ = AtrioventricularBlock?.VerificationStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, i_);
			CqlCode k_ = QICoreCommon_2_0_000.Instance.confirmed(context);
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Has Diagnosis of Cardiac Pacer in Situ")]
	public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ(CqlContext context)
	{
		CqlValueSet a_ = this.Cardiac_Pacer_in_Situ(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition CardiacPacerDiagnosis)
		{
			bool? f_ = AHAOverall_2_6_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, CardiacPacerDiagnosis as object);
			bool? g_ = QICoreCommon_2_0_000.Instance.isActive(context, CardiacPacerDiagnosis);
			bool? h_ = context.Operators.And(f_, g_);
			CodeableConcept i_ = CardiacPacerDiagnosis?.VerificationStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, i_);
			CqlCode k_ = QICoreCommon_2_0_000.Instance.confirmed(context);
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Has Cardiac Pacer Device Implanted")]
	public bool? Has_Cardiac_Pacer_Device_Implanted(CqlContext context)
	{
		CqlValueSet a_ = this.Cardiac_Pacer(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_(Procedure ImplantedCardiacPacer)
		{
			IEnumerable<Encounter> h_ = AHAOverall_2_6_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				DataType m_ = ImplantedCardiacPacer?.Performed;
				object n_ = FHIRHelpers_4_3_000.Instance.ToValue(context, m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.toInterval(context, n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				Period q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, q_);
				CqlDateTime s_ = context.Operators.End(r_);
				bool? t_ = context.Operators.Before(p_, s_, default);

				return t_;
			};
			IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
			Procedure k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				ImplantedCardiacPacer;
			IEnumerable<Procedure> l_ = context.Operators.Select<Encounter, Procedure>(j_, k_);

			return l_;
		};
		IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
		bool? e_(Procedure ImplantedCardiacPacer)
		{
			Code<EventStatus> u_ = ImplantedCardiacPacer?.StatusElement;
			EventStatus? v_ = u_?.Value;
			string w_ = context.Operators.Convert<string>(v_);
			bool? x_ = context.Operators.Equal(w_, "completed");

			return x_;
		};
		IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
		bool? g_ = context.Operators.Exists<Procedure>(f_);

		return g_;
	}


    [CqlDeclaration("Atrioventricular Block without Cardiac Pacer")]
	public bool? Atrioventricular_Block_without_Cardiac_Pacer(CqlContext context)
	{
		bool? a_ = this.Has_Atrioventricular_Block_Diagnosis(context);
		bool? b_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ(context);
		bool? c_ = context.Operators.Not(b_);
		bool? d_ = context.Operators.And(a_, c_);
		bool? e_ = this.Has_Cardiac_Pacer_Device_Implanted(context);
		bool? f_ = context.Operators.Not(e_);
		bool? g_ = context.Operators.And(d_, f_);

		return g_;
	}


    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions(CqlContext context)
	{
		bool? a_ = this.Has_Consecutive_Heart_Rates_Less_than_50(context);
		bool? b_ = this.Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(context);
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_Arrhythmia_Diagnosis(context);
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = this.Has_Hypotension_Diagnosis(context);
		bool? g_ = context.Operators.Or(e_, f_);
		bool? h_ = this.Has_Asthma_Diagnosis(context);
		bool? i_ = context.Operators.Or(g_, h_);
		bool? j_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(context);
		bool? k_ = context.Operators.Or(i_, j_);
		bool? l_ = this.Has_Bradycardia_Diagnosis(context);
		bool? m_ = context.Operators.Or(k_, l_);
		bool? n_ = this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(context);
		bool? o_ = context.Operators.Or(m_, n_);
		bool? p_ = this.Atrioventricular_Block_without_Cardiac_Pacer(context);
		bool? q_ = context.Operators.Or(o_, p_);

		return q_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}

}
