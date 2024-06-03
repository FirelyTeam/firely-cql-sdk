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
[CqlLibrary("HospitalHarmOpioidRelatedAdverseEventsFHIR", "0.1.000")]
public class HospitalHarmOpioidRelatedAdverseEventsFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlValueSet> __Operating_Room_Suite;
    internal Lazy<CqlValueSet> __Opioid_Antagonist;
    internal Lazy<CqlValueSet> __Opioids__All;
    internal Lazy<CqlValueSet> __Routes_of_Administration_for_Opioid_Antagonists;
    internal Lazy<CqlCode> __Dead;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __HSLOC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter;
    internal Lazy<IEnumerable<MedicationAdministration>> __Opioid_Administration;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Opioid_Administration_Outside_of_Operating_Room;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<MedicationAdministration>> __Opioid_Antagonist_Administration;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public HospitalHarmOpioidRelatedAdverseEventsFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);

        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Operating_Room_Suite = new Lazy<CqlValueSet>(this.Operating_Room_Suite_Value);
        __Opioid_Antagonist = new Lazy<CqlValueSet>(this.Opioid_Antagonist_Value);
        __Opioids__All = new Lazy<CqlValueSet>(this.Opioids__All_Value);
        __Routes_of_Administration_for_Opioid_Antagonists = new Lazy<CqlValueSet>(this.Routes_of_Administration_for_Opioid_Antagonists_Value);
        __Dead = new Lazy<CqlCode>(this.Dead_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __HSLOC = new Lazy<CqlCode[]>(this.HSLOC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Qualifying_Encounter = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_Value);
        __Opioid_Administration = new Lazy<IEnumerable<MedicationAdministration>>(this.Opioid_Administration_Value);
        __Encounter_with_Opioid_Administration_Outside_of_Operating_Room = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Opioid_Administration_Outside_of_Operating_Room_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Opioid_Antagonist_Administration = new Lazy<IEnumerable<MedicationAdministration>>(this.Opioid_Antagonist_Administration_Value);
        __Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }

    #endregion

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet Operating_Room_Suite_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141", null);

    [CqlDeclaration("Operating Room Suite")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141")]
	public CqlValueSet Operating_Room_Suite() => 
		__Operating_Room_Suite.Value;

	private CqlValueSet Opioid_Antagonist_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119", null);

    [CqlDeclaration("Opioid Antagonist")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119")]
	public CqlValueSet Opioid_Antagonist() => 
		__Opioid_Antagonist.Value;

	private CqlValueSet Opioids__All_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226", null);

    [CqlDeclaration("Opioids, All")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226")]
	public CqlValueSet Opioids__All() => 
		__Opioids__All.Value;

	private CqlValueSet Routes_of_Administration_for_Opioid_Antagonists_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187", null);

    [CqlDeclaration("Routes of Administration for Opioid Antagonists")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187")]
	public CqlValueSet Routes_of_Administration_for_Opioid_Antagonists() => 
		__Routes_of_Administration_for_Opioid_Antagonists.Value;

	private CqlCode Dead_Value() => 
		new CqlCode("419099009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Dead")]
	public CqlCode Dead() => 
		__Dead.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("419099009", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] HSLOC_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("HSLOC")]
	public CqlCode[] HSLOC() => 
		__HSLOC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("HospitalHarmOpioidRelatedAdverseEventsFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter InpatientEncounter)
		{
			var e_ = this.Patient();
			var f_ = e_?.BirthDateElement;
			var g_ = f_?.Value;
			var h_ = context.Operators.Convert<CqlDate>(g_);
			var i_ = InpatientEncounter?.Period;
			var j_ = FHIRHelpers_4_3_000.ToInterval(i_);
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.DateFrom(k_);
			var m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
			var n_ = context.Operators.GreaterOrEqual(m_, 18);
			var p_ = FHIRHelpers_4_3_000.ToInterval(i_);
			var q_ = context.Operators.End(p_);
			var r_ = this.Measurement_Period();
			var s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
			var t_ = context.Operators.And(n_, s_);
			var u_ = InpatientEncounter?.StatusElement;
			var v_ = u_?.Value;
			var w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
			var x_ = context.Operators.Equal(w_, "finished");
			var y_ = context.Operators.And(t_, x_);

			return y_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private IEnumerable<MedicationAdministration> Opioid_Administration_Value()
	{
		var a_ = this.Opioids__All();
		var b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration Opioids)
		{
			var h_ = Opioids?.StatusElement;
			var i_ = h_?.Value;
			var j_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(i_);
			var k_ = context.Operators.Equal(j_, "completed");
			var m_ = h_?.Value;
			var n_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(m_);
			var o_ = context.Operators.Equal(n_, "not-done");
			var p_ = context.Operators.Not(o_);
			var q_ = context.Operators.And(k_, p_);

			return q_;
		};
		var g_ = context.Operators.Where<MedicationAdministration>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Opioid Administration")]
	public IEnumerable<MedicationAdministration> Opioid_Administration() => 
		__Opioid_Administration.Value;

	private IEnumerable<Encounter> Encounter_with_Opioid_Administration_Outside_of_Operating_Room_Value()
	{
		var a_ = this.Qualifying_Encounter();
		IEnumerable<Encounter> b_(Encounter InpatientEncounter)
		{
			var d_ = this.Opioid_Administration();
			bool? e_(MedicationAdministration OpioidGiven)
			{
				var i_ = OpioidGiven?.Effective;
				var j_ = FHIRHelpers_4_3_000.ToValue(i_);
				var k_ = QICoreCommon_2_0_000.ToInterval(j_);
				var l_ = context.Operators.Start(k_);
				var m_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientEncounter);
				var n_ = context.Operators.In<CqlDateTime>(l_, m_, null);
				var o_ = InpatientEncounter?.Location;
				bool? p_(Encounter.LocationComponent EncounterLocation)
				{
					var u_ = EncounterLocation?.Location;
					var v_ = CQMCommon_2_0_000.GetLocation(u_);
					var w_ = v_?.Type;
					CqlConcept x_(CodeableConcept @this)
					{
						var aj_ = FHIRHelpers_4_3_000.ToConcept(@this);

						return aj_;
					};
					var y_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)w_, x_);
					var z_ = this.Operating_Room_Suite();
					var aa_ = context.Operators.ConceptsInValueSet(y_, z_);
					var ab_ = OpioidGiven?.Effective;
					var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
					var ad_ = QICoreCommon_2_0_000.ToInterval(ac_);
					var ae_ = context.Operators.Start(ad_);
					var af_ = EncounterLocation?.Period;
					var ag_ = FHIRHelpers_4_3_000.ToInterval(af_);
					var ah_ = context.Operators.In<CqlDateTime>(ae_, ag_, null);
					var ai_ = context.Operators.And(aa_, ah_);

					return ai_;
				};
				var q_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)o_, p_);
				var r_ = context.Operators.Exists<Encounter.LocationComponent>(q_);
				var s_ = context.Operators.Not(r_);
				var t_ = context.Operators.And(n_, s_);

				return t_;
			};
			var f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
			Encounter g_(MedicationAdministration OpioidGiven) => 
				InpatientEncounter;
			var h_ = context.Operators.Select<MedicationAdministration, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Opioid Administration Outside of Operating Room")]
	public IEnumerable<Encounter> Encounter_with_Opioid_Administration_Outside_of_Operating_Room() => 
		__Encounter_with_Opioid_Administration_Outside_of_Operating_Room.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Encounter_with_Opioid_Administration_Outside_of_Operating_Room();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<MedicationAdministration> Opioid_Antagonist_Administration_Value()
	{
		var a_ = this.Opioid_Antagonist();
		var b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration AntagonistGiven)
		{
			var h_ = AntagonistGiven?.StatusElement;
			var i_ = h_?.Value;
			var j_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(i_);
			var k_ = context.Operators.Equal(j_, "completed");
			var m_ = h_?.Value;
			var n_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(m_);
			var o_ = context.Operators.Equal(n_, "not-done");
			var p_ = context.Operators.Not(o_);
			var q_ = context.Operators.And(k_, p_);

			return q_;
		};
		var g_ = context.Operators.Where<MedicationAdministration>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Opioid Antagonist Administration")]
	public IEnumerable<MedicationAdministration> Opioid_Antagonist_Administration() => 
		__Opioid_Antagonist_Administration.Value;

	private IEnumerable<Encounter> Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid_Value()
	{
		var a_ = this.Opioid_Antagonist_Administration();
		var b_ = this.Opioid_Administration();
		var c_ = this.Denominator();
		var d_ = context.Operators.CrossJoin<MedicationAdministration, MedicationAdministration, Encounter>(a_, b_, c_);
		Tuple_DiOQPVXLKifMhgTIYEEjRUSaD e_(ValueTuple<MedicationAdministration, MedicationAdministration, Encounter> _valueTuple)
		{
			var k_ = new Tuple_DiOQPVXLKifMhgTIYEEjRUSaD
			{
				OpioidAntagonistGiven = _valueTuple.Item1,
				OpioidGiven = _valueTuple.Item2,
				EncounterWithQualifyingAge = _valueTuple.Item3,
			};

			return k_;
		};
		var f_ = context.Operators.Select<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>, Tuple_DiOQPVXLKifMhgTIYEEjRUSaD>(d_, e_);
		bool? g_(Tuple_DiOQPVXLKifMhgTIYEEjRUSaD tuple_dioqpvxlkifmhgtiyeejrusad)
		{
			var l_ = tuple_dioqpvxlkifmhgtiyeejrusad.EncounterWithQualifyingAge?.Location;
			bool? m_(Encounter.LocationComponent EncounterLocation)
			{
				var bh_ = EncounterLocation?.Location;
				var bi_ = CQMCommon_2_0_000.GetLocation(bh_);
				var bj_ = bi_?.Type;
				CqlConcept bk_(CodeableConcept @this)
				{
					var bw_ = FHIRHelpers_4_3_000.ToConcept(@this);

					return bw_;
				};
				var bl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bj_, bk_);
				var bm_ = this.Operating_Room_Suite();
				var bn_ = context.Operators.ConceptsInValueSet(bl_, bm_);
				var bo_ = tuple_dioqpvxlkifmhgtiyeejrusad.OpioidAntagonistGiven?.Effective;
				var bp_ = FHIRHelpers_4_3_000.ToValue(bo_);
				var bq_ = QICoreCommon_2_0_000.ToInterval(bp_);
				var br_ = context.Operators.Start(bq_);
				var bs_ = EncounterLocation?.Period;
				var bt_ = FHIRHelpers_4_3_000.ToInterval(bs_);
				var bu_ = context.Operators.In<CqlDateTime>(br_, bt_, null);
				var bv_ = context.Operators.And(bn_, bu_);

				return bv_;
			};
			var n_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)l_, m_);
			var o_ = context.Operators.Exists<Encounter.LocationComponent>(n_);
			var p_ = context.Operators.Not(o_);
			var q_ = tuple_dioqpvxlkifmhgtiyeejrusad.OpioidAntagonistGiven?.Effective;
			var r_ = FHIRHelpers_4_3_000.ToValue(q_);
			var s_ = QICoreCommon_2_0_000.ToInterval(r_);
			var t_ = context.Operators.Start(s_);
			var u_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_dioqpvxlkifmhgtiyeejrusad.EncounterWithQualifyingAge);
			var v_ = context.Operators.In<CqlDateTime>(t_, u_, null);
			var w_ = tuple_dioqpvxlkifmhgtiyeejrusad.OpioidGiven?.Effective;
			var x_ = FHIRHelpers_4_3_000.ToValue(w_);
			var y_ = QICoreCommon_2_0_000.ToInterval(x_);
			var z_ = context.Operators.Start(y_);
			var ab_ = context.Operators.In<CqlDateTime>(z_, u_, null);
			var ac_ = context.Operators.And(v_, ab_);
			var ae_ = FHIRHelpers_4_3_000.ToValue(w_);
			var af_ = QICoreCommon_2_0_000.ToInterval(ae_);
			var ag_ = context.Operators.End(af_);
			var ai_ = FHIRHelpers_4_3_000.ToValue(q_);
			var aj_ = QICoreCommon_2_0_000.ToInterval(ai_);
			var ak_ = context.Operators.Start(aj_);
			var al_ = context.Operators.Quantity(12m, "hours");
			var am_ = context.Operators.Subtract(ak_, al_);
			var ao_ = FHIRHelpers_4_3_000.ToValue(q_);
			var ap_ = QICoreCommon_2_0_000.ToInterval(ao_);
			var aq_ = context.Operators.Start(ap_);
			var ar_ = context.Operators.Interval(am_, aq_, true, false);
			var as_ = context.Operators.In<CqlDateTime>(ag_, ar_, null);
			var au_ = FHIRHelpers_4_3_000.ToValue(q_);
			var av_ = QICoreCommon_2_0_000.ToInterval(au_);
			var aw_ = context.Operators.Start(av_);
			var ax_ = context.Operators.Not((bool?)(aw_ is null));
			var ay_ = context.Operators.And(as_, ax_);
			var az_ = context.Operators.And(ac_, ay_);
			var ba_ = tuple_dioqpvxlkifmhgtiyeejrusad.OpioidAntagonistGiven?.Dosage;
			var bb_ = ba_?.Route;
			var bc_ = FHIRHelpers_4_3_000.ToConcept(bb_);
			var bd_ = this.Routes_of_Administration_for_Opioid_Antagonists();
			var be_ = context.Operators.ConceptInValueSet(bc_, bd_);
			var bf_ = context.Operators.And(az_, be_);
			var bg_ = context.Operators.And(p_, bf_);

			return bg_;
		};
		var h_ = context.Operators.Where<Tuple_DiOQPVXLKifMhgTIYEEjRUSaD>(f_, g_);
		Encounter i_(Tuple_DiOQPVXLKifMhgTIYEEjRUSaD tuple_dioqpvxlkifmhgtiyeejrusad) => 
			tuple_dioqpvxlkifmhgtiyeejrusad.EncounterWithQualifyingAge;
		var j_ = context.Operators.Select<Tuple_DiOQPVXLKifMhgTIYEEjRUSaD, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Non Enteral Opioid Antagonist Administration Outside of Operating Room and within 12 Hrs After Opioid")]
	public IEnumerable<Encounter> Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid() => 
		__Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

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
