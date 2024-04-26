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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter InpatientEncounter)
		{
			Patient e_ = this.Patient();
			CqlDate f_ = context.Operators.Convert<CqlDate>(e_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			int? j_ = context.Operators.CalculateAgeAt(f_, i_, "year");
			bool? k_ = context.Operators.GreaterOrEqual(j_, 18);
			CqlDateTime m_ = context.Operators.End(g_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
			bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");
			bool? p_ = context.Operators.And(k_, o_);
			Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(InpatientEncounter?.StatusElement?.Value);
			bool? r_ = context.Operators.Equal(q_, "finished");
			bool? s_ = context.Operators.And(p_, r_);

			return s_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Value()
	{
		CqlValueSet a_ = this.Hypoglycemics_Severe_Hypoglycemia();
		IEnumerable<MedicationAdministration> b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		IEnumerable<MedicationAdministration> d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		IEnumerable<MedicationAdministration> e_ = context.Operators.ListUnion<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration HypoMedication)
		{
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> h_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(HypoMedication?.StatusElement?.Value);
			bool? i_ = context.Operators.Equal(h_, "completed");
			bool? k_ = context.Operators.Equal(h_, "not-done");
			bool? l_ = context.Operators.Not(k_);
			bool? m_ = context.Operators.And(i_, l_);

			return m_;
		};
		IEnumerable<MedicationAdministration> g_ = context.Operators.Where<MedicationAdministration>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Hypoglycemic Medication Administration")]
	public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration() => 
		__Hypoglycemic_Medication_Administration.Value;

	private IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Administration_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
		{
			IEnumerable<MedicationAdministration> d_ = this.Hypoglycemic_Medication_Administration();
			bool? e_(MedicationAdministration HypoglycemicMedication)
			{
				object i_ = FHIRHelpers_4_3_000.ToValue(HypoglycemicMedication?.Effective);
				CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.ToInterval(i_);
				CqlDateTime k_ = context.Operators.Start(j_);
				CqlInterval<CqlDateTime> l_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, null);

				return m_;
			};
			IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
			Encounter g_(MedicationAdministration HypoglycemicMedication) => 
				InpatientHospitalization;
			IEnumerable<Encounter> h_ = context.Operators.Select<MedicationAdministration, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Hypoglycemic Medication Administration")]
	public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Administration() => 
		__Encounter_with_Hypoglycemic_Medication_Administration.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Hypoglycemic_Medication_Administration();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Observation> Glucose_Test_with_Result_Less_Than_40_Value()
	{
		IEnumerable<Encounter> a_ = this.Denominator();
		IEnumerable<MedicationAdministration> b_ = this.Hypoglycemic_Medication_Administration();
		CqlValueSet c_ = this.Glucose_Lab_Test_Mass_Per_Volume();
		IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(c_, null);
		IEnumerable<ValueTuple<Encounter,MedicationAdministration,Observation>> e_ = context.Operators.CrossJoin<Encounter, MedicationAdministration, Observation>(a_, b_, d_);
		Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ f_(ValueTuple<Encounter,MedicationAdministration,Observation> _valueTuple)
		{
			Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ l_ = new Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ
			{
				QualifyingEncounter = _valueTuple.Item1,
				HypoglycemicMedication = _valueTuple.Item2,
				GlucoseTest = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ> g_ = context.Operators.Select<ValueTuple<Encounter,MedicationAdministration,Observation>, Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ>(e_, f_);
		bool? h_(Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ tuple_dsfjbilfcbvjwbysgxhdjckiz)
		{
			object m_()
			{
				bool ap_()
				{
					object as_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					bool at_ = as_ is CqlDateTime;

					return at_;
				};
				bool aq_()
				{
					object au_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					bool av_ = au_ is CqlInterval<CqlDateTime>;

					return av_;
				};
				bool ar_()
				{
					object aw_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					bool ax_ = aw_ is CqlDateTime;

					return ax_;
				};
				if (ap_())
				{
					object ay_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((ay_ as CqlDateTime) as object);
				}
				else if (aq_())
				{
					object az_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((az_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ar_())
				{
					object ba_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((ba_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime n_ = QICoreCommon_2_0_000.Earliest(m_());
			CqlInterval<CqlDateTime> o_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_dsfjbilfcbvjwbysgxhdjckiz.QualifyingEncounter);
			bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, null);
			Code<ObservationStatus> q_ = context.Operators.Convert<Code<ObservationStatus>>(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.StatusElement?.Value);
			string r_ = context.Operators.Convert<string>(q_);
			string[] s_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? t_ = context.Operators.In<string>(r_, (s_ as IEnumerable<string>));
			bool? u_ = context.Operators.And(p_, t_);
			object v_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Value);
			CqlQuantity w_ = context.Operators.Quantity(40m, "mg/dL");
			bool? x_ = context.Operators.Less((v_ as CqlQuantity), w_);
			bool? y_ = context.Operators.And(u_, x_);
			object z_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.HypoglycemicMedication?.Effective);
			CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_0_000.ToInterval(z_);
			CqlDateTime ab_ = context.Operators.Start(aa_);
			object ac_()
			{
				bool bb_()
				{
					object be_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					bool bf_ = be_ is CqlDateTime;

					return bf_;
				};
				bool bc_()
				{
					object bg_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					bool bh_ = bg_ is CqlInterval<CqlDateTime>;

					return bh_;
				};
				bool bd_()
				{
					object bi_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					bool bj_ = bi_ is CqlDateTime;

					return bj_;
				};
				if (bb_())
				{
					object bk_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bk_ as CqlDateTime) as object);
				}
				else if (bc_())
				{
					object bl_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bl_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bd_())
				{
					object bm_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bm_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime ad_ = QICoreCommon_2_0_000.Earliest(ac_());
			CqlQuantity ae_ = context.Operators.Quantity(24m, "hours");
			CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
			object ag_()
			{
				bool bn_()
				{
					object bq_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					bool br_ = bq_ is CqlDateTime;

					return br_;
				};
				bool bo_()
				{
					object bs_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					bool bt_ = bs_ is CqlInterval<CqlDateTime>;

					return bt_;
				};
				bool bp_()
				{
					object bu_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					bool bv_ = bu_ is CqlDateTime;

					return bv_;
				};
				if (bn_())
				{
					object bw_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bw_ as CqlDateTime) as object);
				}
				else if (bo_())
				{
					object bx_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bx_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bp_())
				{
					object by_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((by_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime ah_ = QICoreCommon_2_0_000.Earliest(ag_());
			CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(af_, ah_, true, true);
			bool? aj_ = context.Operators.In<CqlDateTime>(ab_, ai_, null);
			object ak_()
			{
				bool bz_()
				{
					object cc_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					bool cd_ = cc_ is CqlDateTime;

					return cd_;
				};
				bool ca_()
				{
					object ce_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					bool cf_ = ce_ is CqlInterval<CqlDateTime>;

					return cf_;
				};
				bool cb_()
				{
					object cg_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);
					bool ch_ = cg_ is CqlDateTime;

					return ch_;
				};
				if (bz_())
				{
					object ci_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((ci_ as CqlDateTime) as object);
				}
				else if (ca_())
				{
					object cj_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((cj_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (cb_())
				{
					object ck_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((ck_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime al_ = QICoreCommon_2_0_000.Earliest(ak_());
			bool? am_ = context.Operators.Not((bool?)(al_ is null));
			bool? an_ = context.Operators.And(aj_, am_);
			bool? ao_ = context.Operators.And(y_, an_);

			return ao_;
		};
		IEnumerable<Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ> i_ = context.Operators.Where<Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ>(g_, h_);
		Observation j_(Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ tuple_dsfjbilfcbvjwbysgxhdjckiz) => 
			tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest;
		IEnumerable<Observation> k_ = context.Operators.Select<Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ, Observation>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Glucose Test with Result Less Than 40")]
	public IEnumerable<Observation> Glucose_Test_with_Result_Less_Than_40() => 
		__Glucose_Test_with_Result_Less_Than_40.Value;

	private IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80_Value()
	{
		IEnumerable<Encounter> a_ = this.Denominator();
		IEnumerable<Observation> b_ = this.Glucose_Test_with_Result_Less_Than_40();
		CqlValueSet c_ = this.Glucose_Lab_Test_Mass_Per_Volume();
		IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(c_, null);
		IEnumerable<ValueTuple<Encounter,Observation,Observation>> e_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, b_, d_);
		Tuple_CQTbBRGObHbJhTLCMKYTEOihZ f_(ValueTuple<Encounter,Observation,Observation> _valueTuple)
		{
			Tuple_CQTbBRGObHbJhTLCMKYTEOihZ l_ = new Tuple_CQTbBRGObHbJhTLCMKYTEOihZ
			{
				QualifyingEncounter = _valueTuple.Item1,
				LowGlucoseTest = _valueTuple.Item2,
				FollowupGlucoseTest = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_CQTbBRGObHbJhTLCMKYTEOihZ> g_ = context.Operators.Select<ValueTuple<Encounter,Observation,Observation>, Tuple_CQTbBRGObHbJhTLCMKYTEOihZ>(e_, f_);
		bool? h_(Tuple_CQTbBRGObHbJhTLCMKYTEOihZ tuple_cqtbbrgobhbjhtlcmkyteoihz)
		{
			object m_()
			{
				bool aw_()
				{
					object az_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);
					bool ba_ = az_ is CqlDateTime;

					return ba_;
				};
				bool ax_()
				{
					object bb_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);
					bool bc_ = bb_ is CqlInterval<CqlDateTime>;

					return bc_;
				};
				bool ay_()
				{
					object bd_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);
					bool be_ = bd_ is CqlDateTime;

					return be_;
				};
				if (aw_())
				{
					object bf_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((bf_ as CqlDateTime) as object);
				}
				else if (ax_())
				{
					object bg_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((bg_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ay_())
				{
					object bh_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((bh_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime n_ = QICoreCommon_2_0_000.Earliest(m_());
			object o_()
			{
				bool bi_()
				{
					object bl_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					bool bm_ = bl_ is CqlDateTime;

					return bm_;
				};
				bool bj_()
				{
					object bn_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					bool bo_ = bn_ is CqlInterval<CqlDateTime>;

					return bo_;
				};
				bool bk_()
				{
					object bp_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					bool bq_ = bp_ is CqlDateTime;

					return bq_;
				};
				if (bi_())
				{
					object br_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((br_ as CqlDateTime) as object);
				}
				else if (bj_())
				{
					object bs_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bs_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bk_())
				{
					object bt_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bt_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime p_ = QICoreCommon_2_0_000.Earliest(o_());
			object q_()
			{
				bool bu_()
				{
					object bx_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					bool by_ = bx_ is CqlDateTime;

					return by_;
				};
				bool bv_()
				{
					object bz_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					bool ca_ = bz_ is CqlInterval<CqlDateTime>;

					return ca_;
				};
				bool bw_()
				{
					object cb_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					bool cc_ = cb_ is CqlDateTime;

					return cc_;
				};
				if (bu_())
				{
					object cd_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((cd_ as CqlDateTime) as object);
				}
				else if (bv_())
				{
					object ce_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((ce_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bw_())
				{
					object cf_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((cf_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime r_ = QICoreCommon_2_0_000.Earliest(q_());
			CqlQuantity s_ = context.Operators.Quantity(5m, "minutes");
			CqlDateTime t_ = context.Operators.Add(r_, s_);
			CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, t_, false, true);
			bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, null);
			object w_()
			{
				bool cg_()
				{
					object cj_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					bool ck_ = cj_ is CqlDateTime;

					return ck_;
				};
				bool ch_()
				{
					object cl_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					bool cm_ = cl_ is CqlInterval<CqlDateTime>;

					return cm_;
				};
				bool ci_()
				{
					object cn_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					bool co_ = cn_ is CqlDateTime;

					return co_;
				};
				if (cg_())
				{
					object cp_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((cp_ as CqlDateTime) as object);
				}
				else if (ch_())
				{
					object cq_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((cq_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ci_())
				{
					object cr_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((cr_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime x_ = QICoreCommon_2_0_000.Earliest(w_());
			bool? y_ = context.Operators.Not((bool?)(x_ is null));
			bool? z_ = context.Operators.And(v_, y_);
			object aa_()
			{
				bool cs_()
				{
					object cv_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					bool cw_ = cv_ is CqlDateTime;

					return cw_;
				};
				bool ct_()
				{
					object cx_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					bool cy_ = cx_ is CqlInterval<CqlDateTime>;

					return cy_;
				};
				bool cu_()
				{
					object cz_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);
					bool da_ = cz_ is CqlDateTime;

					return da_;
				};
				if (cs_())
				{
					object db_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((db_ as CqlDateTime) as object);
				}
				else if (ct_())
				{
					object dc_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((dc_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (cu_())
				{
					object dd_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((dd_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime ab_ = QICoreCommon_2_0_000.Earliest(aa_());
			CqlInterval<CqlDateTime> ac_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_cqtbbrgobhbjhtlcmkyteoihz.QualifyingEncounter);
			bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, null);
			bool? ae_ = context.Operators.And(z_, ad_);
			object af_()
			{
				bool de_()
				{
					object dh_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);
					bool di_ = dh_ is CqlDateTime;

					return di_;
				};
				bool df_()
				{
					object dj_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);
					bool dk_ = dj_ is CqlInterval<CqlDateTime>;

					return dk_;
				};
				bool dg_()
				{
					object dl_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);
					bool dm_ = dl_ is CqlDateTime;

					return dm_;
				};
				if (de_())
				{
					object dn_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((dn_ as CqlDateTime) as object);
				}
				else if (df_())
				{
					object do_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((do_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (dg_())
				{
					object dp_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((dp_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime ag_ = QICoreCommon_2_0_000.Earliest(af_());
			bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ac_, null);
			bool? aj_ = context.Operators.And(ae_, ai_);
			bool? ak_ = context.Operators.Equivalent(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.IdElement?.Value, tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.IdElement?.Value);
			bool? al_ = context.Operators.Not(ak_);
			bool? am_ = context.Operators.And(aj_, al_);
			Code<ObservationStatus> an_ = context.Operators.Convert<Code<ObservationStatus>>(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.StatusElement?.Value);
			string ao_ = context.Operators.Convert<string>(an_);
			string[] ap_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? aq_ = context.Operators.In<string>(ao_, (ap_ as IEnumerable<string>));
			bool? ar_ = context.Operators.And(am_, aq_);
			object as_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Value);
			CqlQuantity at_ = context.Operators.Quantity(80m, "mg/dL");
			bool? au_ = context.Operators.Greater((as_ as CqlQuantity), at_);
			bool? av_ = context.Operators.And(ar_, au_);

			return av_;
		};
		IEnumerable<Tuple_CQTbBRGObHbJhTLCMKYTEOihZ> i_ = context.Operators.Where<Tuple_CQTbBRGObHbJhTLCMKYTEOihZ>(g_, h_);
		Observation j_(Tuple_CQTbBRGObHbJhTLCMKYTEOihZ tuple_cqtbbrgobhbjhtlcmkyteoihz) => 
			tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest;
		IEnumerable<Observation> k_ = context.Operators.Select<Tuple_CQTbBRGObHbJhTLCMKYTEOihZ, Observation>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Low Glucose Test Followed By Glucose Test Result Greater Than 80")]
	public IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80() => 
		__Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80.Value;

	private IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event_Value()
	{
		IEnumerable<Observation> a_ = this.Glucose_Test_with_Result_Less_Than_40();
		bool? b_(Observation LowGlucoseTest)
		{
			IEnumerable<Observation> d_ = this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80();
			bool? e_(Observation @this)
			{
				bool? k_ = context.Operators.Not((bool?)(((@this is Resource)
	? ((@this as Resource).IdElement)
	: null)?.Value is null));

				return k_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			string g_(Observation @this) => 
				((@this is Resource)
	? ((@this as Resource).IdElement)
	: null)?.Value;
			IEnumerable<string> h_ = context.Operators.Select<Observation, string>(f_, g_);
			bool? i_ = context.Operators.In<string>(LowGlucoseTest?.IdElement?.Value, h_);
			bool? j_ = context.Operators.Not(i_);

			return j_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Severe Hypoglycemic Harm Event")]
	public IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event() => 
		__Severe_Hypoglycemic_Harm_Event.Value;

	private IEnumerable<Encounter> Encounter_with_Severe_Hypoglycemic_Harm_Event_Value()
	{
		IEnumerable<Encounter> a_ = this.Denominator();
		IEnumerable<Observation> b_ = this.Severe_Hypoglycemic_Harm_Event();
		IEnumerable<ValueTuple<Encounter,Observation>> c_ = context.Operators.CrossJoin<Encounter, Observation>(a_, b_);
		Tuple_DKOWLZZJefTKbjLjeXPNieaFS d_(ValueTuple<Encounter,Observation> _valueTuple)
		{
			Tuple_DKOWLZZJefTKbjLjeXPNieaFS j_ = new Tuple_DKOWLZZJefTKbjLjeXPNieaFS
			{
				QualifyingEncounter = _valueTuple.Item1,
				HypoglycemicEvent = _valueTuple.Item2,
			};

			return j_;
		};
		IEnumerable<Tuple_DKOWLZZJefTKbjLjeXPNieaFS> e_ = context.Operators.Select<ValueTuple<Encounter,Observation>, Tuple_DKOWLZZJefTKbjLjeXPNieaFS>(c_, d_);
		bool? f_(Tuple_DKOWLZZJefTKbjLjeXPNieaFS tuple_dkowlzzjeftkbjljexpnieafs)
		{
			object k_()
			{
				bool o_()
				{
					object r_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);
					bool s_ = r_ is CqlDateTime;

					return s_;
				};
				bool p_()
				{
					object t_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);
					bool u_ = t_ is CqlInterval<CqlDateTime>;

					return u_;
				};
				bool q_()
				{
					object v_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);
					bool w_ = v_ is CqlDateTime;

					return w_;
				};
				if (o_())
				{
					object x_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);

					return ((x_ as CqlDateTime) as object);
				}
				else if (p_())
				{
					object y_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);

					return ((y_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (q_())
				{
					object z_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);

					return ((z_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime l_ = QICoreCommon_2_0_000.Earliest(k_());
			CqlInterval<CqlDateTime> m_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_dkowlzzjeftkbjljexpnieafs.QualifyingEncounter);
			bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, null);

			return n_;
		};
		IEnumerable<Tuple_DKOWLZZJefTKbjLjeXPNieaFS> g_ = context.Operators.Where<Tuple_DKOWLZZJefTKbjLjeXPNieaFS>(e_, f_);
		Encounter h_(Tuple_DKOWLZZJefTKbjLjeXPNieaFS tuple_dkowlzzjeftkbjljexpnieafs) => 
			tuple_dkowlzzjeftkbjljexpnieafs.QualifyingEncounter;
		IEnumerable<Encounter> i_ = context.Operators.Select<Tuple_DKOWLZZJefTKbjLjeXPNieaFS, Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Encounter with Severe Hypoglycemic Harm Event")]
	public IEnumerable<Encounter> Encounter_with_Severe_Hypoglycemic_Harm_Event() => 
		__Encounter_with_Severe_Hypoglycemic_Harm_Event.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Severe_Hypoglycemic_Harm_Event();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

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
