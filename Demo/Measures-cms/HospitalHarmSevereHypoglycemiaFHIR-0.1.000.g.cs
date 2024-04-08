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
[CqlLibrary("HospitalHarmSevereHypoglycemiaFHIR", "0.1.000")]
public class HospitalHarmSevereHypoglycemiaFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __birth_date;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Glucose_Lab_Test_Mass_Per_Volume;
    internal Lazy<CqlValueSet> __Hypoglycemics_Severe_Hypoglycemia;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter;
    internal Lazy<IEnumerable<MedicationAdministration>> __Hypoglycemic_Medication_Administration;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Hypoglycemic_Medication_Administration;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Observation>> __Glucose_Test_with_Result_Less_Than_40;
    internal Lazy<IEnumerable<Observation>> __Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80;
    internal Lazy<IEnumerable<Observation>> __Severe_Hypoglycemic_Harm_Event;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Severe_Hypoglycemic_Harm_Event;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public HospitalHarmSevereHypoglycemiaFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);

        __birth_date = new Lazy<CqlValueSet>(this.birth_date_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Glucose_Lab_Test_Mass_Per_Volume = new Lazy<CqlValueSet>(this.Glucose_Lab_Test_Mass_Per_Volume_Value);
        __Hypoglycemics_Severe_Hypoglycemia = new Lazy<CqlValueSet>(this.Hypoglycemics_Severe_Hypoglycemia_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Qualifying_Encounter = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_Value);
        __Hypoglycemic_Medication_Administration = new Lazy<IEnumerable<MedicationAdministration>>(this.Hypoglycemic_Medication_Administration_Value);
        __Encounter_with_Hypoglycemic_Medication_Administration = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Hypoglycemic_Medication_Administration_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Glucose_Test_with_Result_Less_Than_40 = new Lazy<IEnumerable<Observation>>(this.Glucose_Test_with_Result_Less_Than_40_Value);
        __Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80 = new Lazy<IEnumerable<Observation>>(this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80_Value);
        __Severe_Hypoglycemic_Harm_Event = new Lazy<IEnumerable<Observation>>(this.Severe_Hypoglycemic_Harm_Event_Value);
        __Encounter_with_Severe_Hypoglycemic_Harm_Event = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Severe_Hypoglycemic_Harm_Event_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }

    #endregion

	private CqlValueSet birth_date_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
	public CqlValueSet birth_date() => 
		__birth_date.Value;

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

	private CqlValueSet Glucose_Lab_Test_Mass_Per_Volume_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", null);

    [CqlDeclaration("Glucose Lab Test Mass Per Volume")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34")]
	public CqlValueSet Glucose_Lab_Test_Mass_Per_Volume() => 
		__Glucose_Lab_Test_Mass_Per_Volume.Value;

	private CqlValueSet Hypoglycemics_Severe_Hypoglycemia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", null);

    [CqlDeclaration("Hypoglycemics Severe Hypoglycemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393")]
	public CqlValueSet Hypoglycemics_Severe_Hypoglycemia() => 
		__Hypoglycemics_Severe_Hypoglycemia.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.1.000", "Measurement Period", e_);

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

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter InpatientEncounter)
		{
			var e_ = this.Patient();
			var f_ = context.Operators.Convert<CqlDate>(e_?.BirthDateElement?.Value);
			var g_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = context.Operators.CalculateAgeAt(f_, i_, "year");
			var k_ = context.Operators.GreaterOrEqual(j_, (int?)18);
			var m_ = context.Operators.End(g_);
			var n_ = this.Measurement_Period();
			var o_ = context.Operators.ElementInInterval<CqlDateTime>(m_, n_, "day");
			var p_ = context.Operators.And(k_, o_);
			var q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(InpatientEncounter?.StatusElement?.Value);
			var r_ = context.Operators.Equal(q_, "finished");
			var s_ = context.Operators.And(p_, r_);

			return s_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Value()
	{
		var a_ = this.Hypoglycemics_Severe_Hypoglycemia();
		var b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration HypoMedication)
		{
			var h_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(HypoMedication?.StatusElement?.Value);
			var i_ = context.Operators.Equal(h_, "completed");
			var k_ = context.Operators.Equal(h_, "not-done");
			var l_ = context.Operators.Not(k_);
			var m_ = context.Operators.And(i_, l_);

			return m_;
		};
		var g_ = context.Operators.WhereOrNull<MedicationAdministration>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Hypoglycemic Medication Administration")]
	public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration() => 
		__Hypoglycemic_Medication_Administration.Value;

	private IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Administration_Value()
	{
		var a_ = this.Qualifying_Encounter();
		IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
		{
			var d_ = this.Hypoglycemic_Medication_Administration();
			bool? e_(MedicationAdministration HypoglycemicMedication)
			{
				var i_ = FHIRHelpers_4_3_000.ToValue(HypoglycemicMedication?.Effective);
				var j_ = QICoreCommon_2_0_000.ToInterval(i_);
				var k_ = context.Operators.Start(j_);
				var l_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				var m_ = context.Operators.ElementInInterval<CqlDateTime>(k_, l_, null);

				return m_;
			};
			var f_ = context.Operators.WhereOrNull<MedicationAdministration>(d_, e_);
			Encounter g_(MedicationAdministration HypoglycemicMedication) => 
				InpatientHospitalization;
			var h_ = context.Operators.SelectOrNull<MedicationAdministration, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Hypoglycemic Medication Administration")]
	public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Administration() => 
		__Encounter_with_Hypoglycemic_Medication_Administration.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Encounter_with_Hypoglycemic_Medication_Administration();

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

	private IEnumerable<Observation> Glucose_Test_with_Result_Less_Than_40_Value()
	{
		var a_ = this.Denominator();
		IEnumerable<MedicationAdministration> b_(Encounter _QualifyingEncounter)
		{
			var l_ = this.Hypoglycemic_Medication_Administration();

			return l_;
		};
		Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ c_(Encounter _QualifyingEncounter, MedicationAdministration _HypoglycemicMedication)
		{
			var m_ = new Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ
			{
				QualifyingEncounter = _QualifyingEncounter,
				HypoglycemicMedication = _HypoglycemicMedication,
			};

			return m_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, MedicationAdministration, Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ>(a_, b_, c_);
		IEnumerable<Observation> e_(Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ _QualifyingEncounterHypoglycemicMedication)
		{
			var n_ = this.Glucose_Lab_Test_Mass_Per_Volume();
			var o_ = context.Operators.RetrieveByValueSet<Observation>(n_, null);

			return o_;
		};
		Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ f_(Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ QualifyingEncounterHypoglycemicMedication, Observation _GlucoseTest)
		{
			var p_ = new Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ
			{
				QualifyingEncounter = QualifyingEncounterHypoglycemicMedication.QualifyingEncounter,
				HypoglycemicMedication = QualifyingEncounterHypoglycemicMedication.HypoglycemicMedication,
				GlucoseTest = _GlucoseTest,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ, Observation, Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ>(d_, e_, f_);
		bool? h_(Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ tuple_dsfjbilfcbvjwbysgxhdjckiz)
		{
			object q_()
			{
				bool at_()
				{
					var aw_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					var ax_ = aw_ is CqlDateTime;

					return ax_;
				};
				bool au_()
				{
					var ay_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					var az_ = ay_ is CqlInterval<CqlDateTime>;

					return az_;
				};
				bool av_()
				{
					var ba_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					var bb_ = ba_ is CqlDateTime;

					return bb_;
				};
				if (at_())
				{
					var bc_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bc_ as CqlDateTime) as object);
				}
				else if (au_())
				{
					var bd_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bd_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (av_())
				{
					var be_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((be_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var r_ = QICoreCommon_2_0_000.Earliest(q_());
			var s_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_dsfjbilfcbvjwbysgxhdjckiz.QualifyingEncounter);
			var t_ = context.Operators.ElementInInterval<CqlDateTime>(r_, s_, null);
			var u_ = context.Operators.Convert<Code<ObservationStatus>>(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.StatusElement?.Value);
			var v_ = context.Operators.Convert<string>(u_);
			var w_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var x_ = context.Operators.InList<string>(v_, (w_ as IEnumerable<string>));
			var y_ = context.Operators.And(t_, x_);
			var z_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Value);
			var aa_ = context.Operators.Quantity(40m, "mg/dL");
			var ab_ = context.Operators.Less((z_ as CqlQuantity), aa_);
			var ac_ = context.Operators.And(y_, ab_);
			var ad_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.HypoglycemicMedication?.Effective);
			var ae_ = QICoreCommon_2_0_000.ToInterval(ad_);
			var af_ = context.Operators.Start(ae_);
			object ag_()
			{
				bool bf_()
				{
					var bi_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					var bj_ = bi_ is CqlDateTime;

					return bj_;
				};
				bool bg_()
				{
					var bk_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					var bl_ = bk_ is CqlInterval<CqlDateTime>;

					return bl_;
				};
				bool bh_()
				{
					var bm_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					var bn_ = bm_ is CqlDateTime;

					return bn_;
				};
				if (bf_())
				{
					var bo_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bo_ as CqlDateTime) as object);
				}
				else if (bg_())
				{
					var bp_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bp_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bh_())
				{
					var bq_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bq_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ah_ = QICoreCommon_2_0_000.Earliest(ag_());
			var ai_ = context.Operators.Quantity(24m, "hours");
			var aj_ = context.Operators.Subtract(ah_, ai_);
			object ak_()
			{
				bool br_()
				{
					var bu_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					var bv_ = bu_ is CqlDateTime;

					return bv_;
				};
				bool bs_()
				{
					var bw_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					var bx_ = bw_ is CqlInterval<CqlDateTime>;

					return bx_;
				};
				bool bt_()
				{
					var by_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					var bz_ = by_ is CqlDateTime;

					return bz_;
				};
				if (br_())
				{
					var ca_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((ca_ as CqlDateTime) as object);
				}
				else if (bs_())
				{
					var cb_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((cb_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bt_())
				{
					var cc_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((cc_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var al_ = QICoreCommon_2_0_000.Earliest(ak_());
			var am_ = context.Operators.Interval(aj_, al_, true, true);
			var an_ = context.Operators.ElementInInterval<CqlDateTime>(af_, am_, null);
			object ao_()
			{
				bool cd_()
				{
					var cg_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					var ch_ = cg_ is CqlDateTime;

					return ch_;
				};
				bool ce_()
				{
					var ci_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					var cj_ = ci_ is CqlInterval<CqlDateTime>;

					return cj_;
				};
				bool cf_()
				{
					var ck_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					var cl_ = ck_ is CqlDateTime;

					return cl_;
				};
				if (cd_())
				{
					var cm_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((cm_ as CqlDateTime) as object);
				}
				else if (ce_())
				{
					var cn_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((cn_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (cf_())
				{
					var co_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((co_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ap_ = QICoreCommon_2_0_000.Earliest(ao_());
			var aq_ = context.Operators.Not((bool?)(ap_ is null));
			var ar_ = context.Operators.And(an_, aq_);
			var as_ = context.Operators.And(ac_, ar_);

			return as_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ>(g_, h_);
		Observation j_(Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ tuple_dsfjbilfcbvjwbysgxhdjckiz) => 
			tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ, Observation>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Glucose Test with Result Less Than 40")]
	public IEnumerable<Observation> Glucose_Test_with_Result_Less_Than_40() => 
		__Glucose_Test_with_Result_Less_Than_40.Value;

	private IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80_Value()
	{
		var a_ = this.Denominator();
		IEnumerable<Observation> b_(Encounter _QualifyingEncounter)
		{
			var l_ = this.Glucose_Test_with_Result_Less_Than_40();

			return l_;
		};
		Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ c_(Encounter _QualifyingEncounter, Observation _LowGlucoseTest)
		{
			var m_ = new Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ
			{
				QualifyingEncounter = _QualifyingEncounter,
				LowGlucoseTest = _LowGlucoseTest,
			};

			return m_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, Observation, Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ>(a_, b_, c_);
		IEnumerable<Observation> e_(Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ _QualifyingEncounterLowGlucoseTest)
		{
			var n_ = this.Glucose_Lab_Test_Mass_Per_Volume();
			var o_ = context.Operators.RetrieveByValueSet<Observation>(n_, null);

			return o_;
		};
		Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ f_(Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ QualifyingEncounterLowGlucoseTest, Observation _FollowupGlucoseTest)
		{
			var p_ = new Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ
			{
				QualifyingEncounter = QualifyingEncounterLowGlucoseTest.QualifyingEncounter,
				LowGlucoseTest = QualifyingEncounterLowGlucoseTest.LowGlucoseTest,
				FollowupGlucoseTest = _FollowupGlucoseTest,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ, Observation, Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ>(d_, e_, f_);
		bool? h_(Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ tuple_cqtbbrgobhbjhtlcmkyteoihz)
		{
			object q_()
			{
				bool ba_()
				{
					var bd_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);
					var be_ = bd_ is CqlDateTime;

					return be_;
				};
				bool bb_()
				{
					var bf_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);
					var bg_ = bf_ is CqlInterval<CqlDateTime>;

					return bg_;
				};
				bool bc_()
				{
					var bh_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);
					var bi_ = bh_ is CqlDateTime;

					return bi_;
				};
				if (ba_())
				{
					var bj_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((bj_ as CqlDateTime) as object);
				}
				else if (bb_())
				{
					var bk_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((bk_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bc_())
				{
					var bl_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((bl_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var r_ = QICoreCommon_2_0_000.Earliest(q_());
			object s_()
			{
				bool bm_()
				{
					var bp_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					var bq_ = bp_ is CqlDateTime;

					return bq_;
				};
				bool bn_()
				{
					var br_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					var bs_ = br_ is CqlInterval<CqlDateTime>;

					return bs_;
				};
				bool bo_()
				{
					var bt_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					var bu_ = bt_ is CqlDateTime;

					return bu_;
				};
				if (bm_())
				{
					var bv_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bv_ as CqlDateTime) as object);
				}
				else if (bn_())
				{
					var bw_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bw_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bo_())
				{
					var bx_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bx_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var t_ = QICoreCommon_2_0_000.Earliest(s_());
			object u_()
			{
				bool by_()
				{
					var cb_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					var cc_ = cb_ is CqlDateTime;

					return cc_;
				};
				bool bz_()
				{
					var cd_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					var ce_ = cd_ is CqlInterval<CqlDateTime>;

					return ce_;
				};
				bool ca_()
				{
					var cf_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					var cg_ = cf_ is CqlDateTime;

					return cg_;
				};
				if (by_())
				{
					var ch_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((ch_ as CqlDateTime) as object);
				}
				else if (bz_())
				{
					var ci_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((ci_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ca_())
				{
					var cj_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((cj_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var v_ = QICoreCommon_2_0_000.Earliest(u_());
			var w_ = context.Operators.Quantity(5m, "minutes");
			var x_ = context.Operators.Add(v_, w_);
			var y_ = context.Operators.Interval(t_, x_, false, true);
			var z_ = context.Operators.ElementInInterval<CqlDateTime>(r_, y_, null);
			object aa_()
			{
				bool ck_()
				{
					var cn_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					var co_ = cn_ is CqlDateTime;

					return co_;
				};
				bool cl_()
				{
					var cp_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					var cq_ = cp_ is CqlInterval<CqlDateTime>;

					return cq_;
				};
				bool cm_()
				{
					var cr_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					var cs_ = cr_ is CqlDateTime;

					return cs_;
				};
				if (ck_())
				{
					var ct_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((ct_ as CqlDateTime) as object);
				}
				else if (cl_())
				{
					var cu_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((cu_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (cm_())
				{
					var cv_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((cv_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ab_ = QICoreCommon_2_0_000.Earliest(aa_());
			var ac_ = context.Operators.Not((bool?)(ab_ is null));
			var ad_ = context.Operators.And(z_, ac_);
			object ae_()
			{
				bool cw_()
				{
					var cz_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					var da_ = cz_ is CqlDateTime;

					return da_;
				};
				bool cx_()
				{
					var db_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					var dc_ = db_ is CqlInterval<CqlDateTime>;

					return dc_;
				};
				bool cy_()
				{
					var dd_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					var de_ = dd_ is CqlDateTime;

					return de_;
				};
				if (cw_())
				{
					var df_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((df_ as CqlDateTime) as object);
				}
				else if (cx_())
				{
					var dg_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((dg_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (cy_())
				{
					var dh_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((dh_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var af_ = QICoreCommon_2_0_000.Earliest(ae_());
			var ag_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_cqtbbrgobhbjhtlcmkyteoihz.QualifyingEncounter);
			var ah_ = context.Operators.ElementInInterval<CqlDateTime>(af_, ag_, null);
			var ai_ = context.Operators.And(ad_, ah_);
			object aj_()
			{
				bool di_()
				{
					var dl_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);
					var dm_ = dl_ is CqlDateTime;

					return dm_;
				};
				bool dj_()
				{
					var dn_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);
					var do_ = dn_ is CqlInterval<CqlDateTime>;

					return do_;
				};
				bool dk_()
				{
					var dp_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);
					var dq_ = dp_ is CqlDateTime;

					return dq_;
				};
				if (di_())
				{
					var dr_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((dr_ as CqlDateTime) as object);
				}
				else if (dj_())
				{
					var ds_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((ds_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (dk_())
				{
					var dt_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((dt_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ak_ = QICoreCommon_2_0_000.Earliest(aj_());
			var am_ = context.Operators.ElementInInterval<CqlDateTime>(ak_, ag_, null);
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.Equivalent(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.IdElement?.Value, tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.IdElement?.Value);
			var ap_ = context.Operators.Not(ao_);
			var aq_ = context.Operators.And(an_, ap_);
			var ar_ = context.Operators.Convert<Code<ObservationStatus>>(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.StatusElement?.Value);
			var as_ = context.Operators.Convert<string>(ar_);
			var at_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var au_ = context.Operators.InList<string>(as_, (at_ as IEnumerable<string>));
			var av_ = context.Operators.And(aq_, au_);
			var aw_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Value);
			var ax_ = context.Operators.Quantity(80m, "mg/dL");
			var ay_ = context.Operators.Greater((aw_ as CqlQuantity), ax_);
			var az_ = context.Operators.And(av_, ay_);

			return az_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ>(g_, h_);
		Observation j_(Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ tuple_cqtbbrgobhbjhtlcmkyteoihz) => 
			tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ, Observation>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Low Glucose Test Followed By Glucose Test Result Greater Than 80")]
	public IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80() => 
		__Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80.Value;

	private IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event_Value()
	{
		var a_ = this.Glucose_Test_with_Result_Less_Than_40();
		bool? b_(Observation LowGlucoseTest)
		{
			var d_ = this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80();
			bool? e_(Observation @this)
			{
				var k_ = context.Operators.Not((bool?)(((@this is Resource)
	? ((@this as Resource).IdElement)
	: null)?.Value is null));

				return k_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			string g_(Observation @this) => 
				((@this is Resource)
	? ((@this as Resource).IdElement)
	: null)?.Value;
			var h_ = context.Operators.SelectOrNull<Observation, string>(f_, g_);
			var i_ = context.Operators.InList<string>(LowGlucoseTest?.IdElement?.Value, h_);
			var j_ = context.Operators.Not(i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Severe Hypoglycemic Harm Event")]
	public IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event() => 
		__Severe_Hypoglycemic_Harm_Event.Value;

	private IEnumerable<Encounter> Encounter_with_Severe_Hypoglycemic_Harm_Event_Value()
	{
		var a_ = this.Denominator();
		IEnumerable<Observation> b_(Encounter _QualifyingEncounter)
		{
			var i_ = this.Severe_Hypoglycemic_Harm_Event();

			return i_;
		};
		Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS c_(Encounter _QualifyingEncounter, Observation _HypoglycemicEvent)
		{
			var j_ = new Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS
			{
				QualifyingEncounter = _QualifyingEncounter,
				HypoglycemicEvent = _HypoglycemicEvent,
			};

			return j_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, Observation, Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS>(a_, b_, c_);
		bool? e_(Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS tuple_dkowlzzjeftkbjljexpnieafs)
		{
			object k_()
			{
				bool o_()
				{
					var r_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);
					var s_ = r_ is CqlDateTime;

					return s_;
				};
				bool p_()
				{
					var t_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);
					var u_ = t_ is CqlInterval<CqlDateTime>;

					return u_;
				};
				bool q_()
				{
					var v_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);
					var w_ = v_ is CqlDateTime;

					return w_;
				};
				if (o_())
				{
					var x_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);

					return ((x_ as CqlDateTime) as object);
				}
				else if (p_())
				{
					var y_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);

					return ((y_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (q_())
				{
					var z_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);

					return ((z_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var l_ = QICoreCommon_2_0_000.Earliest(k_());
			var m_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_dkowlzzjeftkbjljexpnieafs.QualifyingEncounter);
			var n_ = context.Operators.ElementInInterval<CqlDateTime>(l_, m_, null);

			return n_;
		};
		var f_ = context.Operators.WhereOrNull<Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS>(d_, e_);
		Encounter g_(Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS tuple_dkowlzzjeftkbjljexpnieafs) => 
			tuple_dkowlzzjeftkbjljexpnieafs.QualifyingEncounter;
		var h_ = context.Operators.SelectOrNull<Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS, Encounter>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Encounter with Severe Hypoglycemic Harm Event")]
	public IEnumerable<Encounter> Encounter_with_Severe_Hypoglycemic_Harm_Event() => 
		__Encounter_with_Severe_Hypoglycemic_Harm_Event.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Encounter_with_Severe_Hypoglycemic_Harm_Event();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

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
