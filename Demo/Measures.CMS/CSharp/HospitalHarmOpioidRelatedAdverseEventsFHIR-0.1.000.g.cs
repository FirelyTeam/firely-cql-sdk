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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("HospitalHarmOpioidRelatedAdverseEventsFHIR", "0.1.000")]
public partial class HospitalHarmOpioidRelatedAdverseEventsFHIR_0_1_000 : ILibrary, ISingleton<HospitalHarmOpioidRelatedAdverseEventsFHIR_0_1_000>
{
    private HospitalHarmOpioidRelatedAdverseEventsFHIR_0_1_000() {}

    public static HospitalHarmOpioidRelatedAdverseEventsFHIR_0_1_000 Instance { get; } = new();

    #region Library Members
    public string Name => "HospitalHarmOpioidRelatedAdverseEventsFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_3_4_000.Instance, CQMCommon_2_0_000.Instance, QICoreCommon_2_0_000.Instance, FHIRHelpers_4_3_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);


    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);


    [CqlDeclaration("Operating Room Suite")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141")]
	public CqlValueSet Operating_Room_Suite	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141", default);


    [CqlDeclaration("Opioid Antagonist")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119")]
	public CqlValueSet Opioid_Antagonist	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119", default);


    [CqlDeclaration("Opioids, All")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226")]
	public CqlValueSet Opioids__All	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226", default);


    [CqlDeclaration("Routes of Administration for Opioid Antagonists")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187")]
	public CqlValueSet Routes_of_Administration_for_Opioid_Antagonists	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187", default);


    [CqlDeclaration("Dead")]
	public CqlCode Dead	(CqlContext context) => 
		new CqlCode("419099009", "http://snomed.info/sct", default, default);


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT	(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("419099009", "http://snomed.info/sct", default, default),
		];

		return a_;
	}


    [CqlDeclaration("HSLOC")]
	public CqlCode[] HSLOC	(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period	(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HospitalHarmOpioidRelatedAdverseEventsFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient	(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter	(CqlContext context)
	{
		CqlValueSet a_ = this.Encounter_Inpatient(context);
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? c_		(Encounter InpatientEncounter)
		{
			Patient e_ = this.Patient(context);
			Date f_ = e_?.BirthDateElement;
			string g_ = f_?.Value;
			CqlDate h_ = context.Operators.ConvertStringToDate(g_);
			Period i_ = InpatientEncounter?.Period;
			CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, i_);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
			bool? n_ = context.Operators.GreaterOrEqual(m_, 18);
			CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, i_);
			CqlDateTime q_ = context.Operators.End(p_);
			CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
			bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
			bool? t_ = context.Operators.And(n_, s_);
			Code<Encounter.EncounterStatus> u_ = InpatientEncounter?.StatusElement;
			Encounter.EncounterStatus? v_ = u_?.Value;
			Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
			bool? x_ = context.Operators.Equal(w_, "finished");
			bool? y_ = context.Operators.And(t_, x_);

			return y_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}


    [CqlDeclaration("Opioid Administration")]
	public IEnumerable<MedicationAdministration> Opioid_Administration	(CqlContext context)
	{
		CqlValueSet a_ = this.Opioids__All(context);
		IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
		IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
		IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
		bool? f_		(MedicationAdministration Opioids)
		{
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> h_ = Opioids?.StatusElement;
			MedicationAdministration.MedicationAdministrationStatusCodes? i_ = h_?.Value;
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> j_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(i_);
			bool? k_ = context.Operators.Equal(j_, "completed");
			MedicationAdministration.MedicationAdministrationStatusCodes? m_ = h_?.Value;
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> n_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(m_);
			bool? o_ = context.Operators.Equal(n_, "not-done");
			bool? p_ = context.Operators.Not(o_);
			bool? q_ = context.Operators.And(k_, p_);

			return q_;
		};
		IEnumerable<MedicationAdministration> g_ = context.Operators.Where<MedicationAdministration>(e_, f_);

		return g_;
	}


    [CqlDeclaration("Encounter with Opioid Administration Outside of Operating Room")]
	public IEnumerable<Encounter> Encounter_with_Opioid_Administration_Outside_of_Operating_Room	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		IEnumerable<Encounter> b_		(Encounter InpatientEncounter)
		{
			IEnumerable<MedicationAdministration> d_ = this.Opioid_Administration(context);
			bool? e_			(MedicationAdministration OpioidGiven)
			{
				DataType i_ = OpioidGiven?.Effective;
				object j_ = FHIRHelpers_4_3_000.Instance.ToValue(context, i_);
				CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.Instance.ToInterval(context, j_);
				CqlDateTime l_ = context.Operators.Start(k_);
				CqlInterval<CqlDateTime> m_ = CQMCommon_2_0_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
				bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);
				List<Encounter.LocationComponent> o_ = InpatientEncounter?.Location;
				bool? p_				(Encounter.LocationComponent EncounterLocation)
				{
					ResourceReference u_ = EncounterLocation?.Location;
					Location v_ = CQMCommon_2_0_000.Instance.GetLocation(context, u_);
					List<CodeableConcept> w_ = v_?.Type;
					CqlConcept x_					(CodeableConcept @this)
					{
						CqlConcept aj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

						return aj_;
					};
					IEnumerable<CqlConcept> y_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)w_, x_);
					CqlValueSet z_ = this.Operating_Room_Suite(context);
					bool? aa_ = context.Operators.ConceptsInValueSet(y_, z_);
					DataType ab_ = OpioidGiven?.Effective;
					object ac_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ab_);
					CqlInterval<CqlDateTime> ad_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ac_);
					CqlDateTime ae_ = context.Operators.Start(ad_);
					Period af_ = EncounterLocation?.Period;
					CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, af_);
					bool? ah_ = context.Operators.In<CqlDateTime>(ae_, ag_, default);
					bool? ai_ = context.Operators.And(aa_, ah_);

					return ai_;
				};
				IEnumerable<Encounter.LocationComponent> q_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)o_, p_);
				bool? r_ = context.Operators.Exists<Encounter.LocationComponent>(q_);
				bool? s_ = context.Operators.Not(r_);
				bool? t_ = context.Operators.And(n_, s_);

				return t_;
			};
			IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
			Encounter g_			(MedicationAdministration OpioidGiven) => 
				InpatientEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<MedicationAdministration, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Opioid_Administration_Outside_of_Operating_Room(context);

		return a_;
	}


    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("Opioid Antagonist Administration")]
	public IEnumerable<MedicationAdministration> Opioid_Antagonist_Administration	(CqlContext context)
	{
		CqlValueSet a_ = this.Opioid_Antagonist(context);
		IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
		IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
		IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
		bool? f_		(MedicationAdministration AntagonistGiven)
		{
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> h_ = AntagonistGiven?.StatusElement;
			MedicationAdministration.MedicationAdministrationStatusCodes? i_ = h_?.Value;
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> j_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(i_);
			bool? k_ = context.Operators.Equal(j_, "completed");
			MedicationAdministration.MedicationAdministrationStatusCodes? m_ = h_?.Value;
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> n_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(m_);
			bool? o_ = context.Operators.Equal(n_, "not-done");
			bool? p_ = context.Operators.Not(o_);
			bool? q_ = context.Operators.And(k_, p_);

			return q_;
		};
		IEnumerable<MedicationAdministration> g_ = context.Operators.Where<MedicationAdministration>(e_, f_);

		return g_;
	}


    [CqlDeclaration("Encounter with Non Enteral Opioid Antagonist Administration Outside of Operating Room and within 12 Hrs After Opioid")]
	public IEnumerable<Encounter> Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid	(CqlContext context)
	{
		IEnumerable<MedicationAdministration> a_ = this.Opioid_Antagonist_Administration(context);
		IEnumerable<MedicationAdministration> b_ = this.Opioid_Administration(context);
		IEnumerable<Encounter> c_ = this.Denominator(context);
		IEnumerable<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>> d_ = context.Operators.CrossJoin<MedicationAdministration, MedicationAdministration, Encounter>(a_, b_, c_);
		(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? e_		(ValueTuple<MedicationAdministration, MedicationAdministration, Encounter> _valueTuple)
		{
			(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? k_ = (CqlTupleMetadata_DBJShWTZiKWMABGVHCaJVcMhY, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?> f_ = context.Operators.Select<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>, (CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? tuple_dioqpvxlkifmhgtiyeejrusad)
		{
			List<Encounter.LocationComponent> l_ = tuple_dioqpvxlkifmhgtiyeejrusad?.EncounterWithQualifyingAge?.Location;
			bool? m_			(Encounter.LocationComponent EncounterLocation)
			{
				ResourceReference bh_ = EncounterLocation?.Location;
				Location bi_ = CQMCommon_2_0_000.Instance.GetLocation(context, bh_);
				List<CodeableConcept> bj_ = bi_?.Type;
				CqlConcept bk_				(CodeableConcept @this)
				{
					CqlConcept bw_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

					return bw_;
				};
				IEnumerable<CqlConcept> bl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bj_, bk_);
				CqlValueSet bm_ = this.Operating_Room_Suite(context);
				bool? bn_ = context.Operators.ConceptsInValueSet(bl_, bm_);
				DataType bo_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidAntagonistGiven?.Effective;
				object bp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bo_);
				CqlInterval<CqlDateTime> bq_ = QICoreCommon_2_0_000.Instance.ToInterval(context, bp_);
				CqlDateTime br_ = context.Operators.Start(bq_);
				Period bs_ = EncounterLocation?.Period;
				CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bs_);
				bool? bu_ = context.Operators.In<CqlDateTime>(br_, bt_, default);
				bool? bv_ = context.Operators.And(bn_, bu_);

				return bv_;
			};
			IEnumerable<Encounter.LocationComponent> n_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)l_, m_);
			bool? o_ = context.Operators.Exists<Encounter.LocationComponent>(n_);
			bool? p_ = context.Operators.Not(o_);
			DataType q_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidAntagonistGiven?.Effective;
			object r_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_);
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlInterval<CqlDateTime> u_ = CQMCommon_2_0_000.Instance.HospitalizationWithObservation(context, tuple_dioqpvxlkifmhgtiyeejrusad?.EncounterWithQualifyingAge);
			bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, default);
			DataType w_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidGiven?.Effective;
			object x_ = FHIRHelpers_4_3_000.Instance.ToValue(context, w_);
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.ToInterval(context, x_);
			CqlDateTime z_ = context.Operators.Start(y_);
			bool? ab_ = context.Operators.In<CqlDateTime>(z_, u_, default);
			bool? ac_ = context.Operators.And(v_, ab_);
			object ae_ = FHIRHelpers_4_3_000.Instance.ToValue(context, w_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ae_);
			CqlDateTime ag_ = context.Operators.End(af_);
			object ai_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
			CqlInterval<CqlDateTime> aj_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ai_);
			CqlDateTime ak_ = context.Operators.Start(aj_);
			CqlQuantity al_ = context.Operators.Quantity(12m, "hours");
			CqlDateTime am_ = context.Operators.Subtract(ak_, al_);
			object ao_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
			CqlInterval<CqlDateTime> ap_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ao_);
			CqlDateTime aq_ = context.Operators.Start(ap_);
			CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(am_, aq_, true, false);
			bool? as_ = context.Operators.In<CqlDateTime>(ag_, ar_, default);
			object au_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
			CqlInterval<CqlDateTime> av_ = QICoreCommon_2_0_000.Instance.ToInterval(context, au_);
			CqlDateTime aw_ = context.Operators.Start(av_);
			bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
			bool? ay_ = context.Operators.And(as_, ax_);
			bool? az_ = context.Operators.And(ac_, ay_);
			MedicationAdministration.DosageComponent ba_ = tuple_dioqpvxlkifmhgtiyeejrusad?.OpioidAntagonistGiven?.Dosage;
			CodeableConcept bb_ = ba_?.Route;
			CqlConcept bc_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, bb_);
			CqlValueSet bd_ = this.Routes_of_Administration_for_Opioid_Antagonists(context);
			bool? be_ = context.Operators.ConceptInValueSet(bc_, bd_);
			bool? bf_ = context.Operators.And(az_, be_);
			bool? bg_ = context.Operators.And(p_, bf_);

			return bg_;
		};
		IEnumerable<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?> h_ = context.Operators.Where<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?>(f_, g_);
		Encounter i_		((CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)? tuple_dioqpvxlkifmhgtiyeejrusad) => 
			tuple_dioqpvxlkifmhgtiyeejrusad?.EncounterWithQualifyingAge;
		IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, MedicationAdministration OpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter EncounterWithQualifyingAge)?, Encounter>(h_, i_);

		return j_;
	}


    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator	(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid(context);

		return a_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity	(CqlContext context)
	{
		(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer	(CqlContext context)
	{
		IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race	(CqlContext context)
	{
		(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex	(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}

    private static CqlTupleMetadata CqlTupleMetadata_DBJShWTZiKWMABGVHCaJVcMhY = new([typeof(MedicationAdministration), typeof(MedicationAdministration), typeof(Encounter)], ["OpioidAntagonistGiven", "OpioidGiven", "EncounterWithQualifyingAge"]);
}
