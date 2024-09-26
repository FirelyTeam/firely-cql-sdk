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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }

    #endregion

	private CqlValueSet birth_date_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", default);

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
	public CqlValueSet birth_date() => 
		__birth_date.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Glucose_Lab_Test_Mass_Per_Volume_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", default);

    [CqlDeclaration("Glucose Lab Test Mass Per Volume")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34")]
	public CqlValueSet Glucose_Lab_Test_Mass_Per_Volume() => 
		__Glucose_Lab_Test_Mass_Per_Volume.Value;

	private CqlValueSet Hypoglycemics_Severe_Hypoglycemia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", default);

    [CqlDeclaration("Hypoglycemics Severe Hypoglycemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393")]
	public CqlValueSet Hypoglycemics_Severe_Hypoglycemia() => 
		__Hypoglycemics_Severe_Hypoglycemia.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);

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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter InpatientEncounter)
		{
			Patient e_ = this.Patient();
			Date f_ = e_?.BirthDateElement;
			string g_ = f_?.Value;
			CqlDate h_ = context.Operators.ConvertStringToDate(g_);
			Period i_ = InpatientEncounter?.Period;
			CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.ToInterval(i_);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
			bool? n_ = context.Operators.GreaterOrEqual(m_, 18);
			CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(i_);
			CqlDateTime q_ = context.Operators.End(p_);
			CqlInterval<CqlDateTime> r_ = this.Measurement_Period();
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

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Value()
	{
		CqlValueSet a_ = this.Hypoglycemics_Severe_Hypoglycemia();
		IEnumerable<MedicationAdministration> b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, default);
		IEnumerable<MedicationAdministration> d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, default);
		IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration HypoMedication)
		{
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> h_ = HypoMedication?.StatusElement;
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
				DataType i_ = HypoglycemicMedication?.Effective;
				object j_ = FHIRHelpers_4_3_000.ToValue(i_);
				CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.ToInterval(j_);
				CqlDateTime l_ = context.Operators.Start(k_);
				CqlInterval<CqlDateTime> m_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);

				return n_;
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
		IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(c_, default);
		IEnumerable<ValueTuple<Encounter, MedicationAdministration, Observation>> e_ = context.Operators.CrossJoin<Encounter, MedicationAdministration, Observation>(a_, b_, d_);
		(Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? f_(ValueTuple<Encounter, MedicationAdministration, Observation> _valueTuple)
		{
			(Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? l_ = (_valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

			return l_;
		};
		IEnumerable<(Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> g_ = context.Operators.Select<ValueTuple<Encounter, MedicationAdministration, Observation>, (Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(e_, f_);
		bool? h_((Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_btymmdgachdragrhofgxbxgho)
		{
			object m_()
			{
				bool au_()
				{
					DataType ax_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object ay_ = FHIRHelpers_4_3_000.ToValue(ax_);
					bool az_ = ay_ is CqlDateTime;

					return az_;
				};
				bool av_()
				{
					DataType ba_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bb_ = FHIRHelpers_4_3_000.ToValue(ba_);
					bool bc_ = bb_ is CqlInterval<CqlDateTime>;

					return bc_;
				};
				bool aw_()
				{
					DataType bd_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object be_ = FHIRHelpers_4_3_000.ToValue(bd_);
					bool bf_ = be_ is CqlDateTime;

					return bf_;
				};
				if (au_())
				{
					DataType bg_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
					CqlDateTime bi_ = bh_ switch { null => null , CqlDateTime a => a/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bi_ as object;
				}
				else if (av_())
				{
					DataType bj_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bk_ = FHIRHelpers_4_3_000.ToValue(bj_);
					CqlInterval<CqlDateTime> bl_ = bk_ switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bl_ as object;
				}
				else if (aw_())
				{
					DataType bm_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bn_ = FHIRHelpers_4_3_000.ToValue(bm_);
					CqlDateTime bo_ = bn_ switch { null => null , CqlDateTime c => c/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bo_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime n_ = QICoreCommon_2_0_000.Earliest(m_());
			CqlInterval<CqlDateTime> o_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_btymmdgachdragrhofgxbxgho?.QualifyingEncounter);
			bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, default);
			Code<ObservationStatus> q_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.StatusElement;
			ObservationStatus? r_ = q_?.Value;
			Code<ObservationStatus> s_ = context.Operators.Convert<Code<ObservationStatus>>(r_);
			string t_ = context.Operators.Convert<string>(s_);
			string[] u_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? v_ = context.Operators.In<string>(t_, u_ as IEnumerable<string>);
			bool? w_ = context.Operators.And(p_, v_);
			DataType x_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Value;
			object y_ = FHIRHelpers_4_3_000.ToValue(x_);
			CqlQuantity z_ = y_ switch { null => null , CqlQuantity d => d/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity aa_ = context.Operators.Quantity(40m, "mg/dL");
			bool? ab_ = context.Operators.Less(z_, aa_);
			bool? ac_ = context.Operators.And(w_, ab_);
			DataType ad_ = tuple_btymmdgachdragrhofgxbxgho?.HypoglycemicMedication?.Effective;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.ToInterval(ae_);
			CqlDateTime ag_ = context.Operators.Start(af_);
			object ah_()
			{
				bool bp_()
				{
					DataType bs_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bt_ = FHIRHelpers_4_3_000.ToValue(bs_);
					bool bu_ = bt_ is CqlDateTime;

					return bu_;
				};
				bool bq_()
				{
					DataType bv_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bw_ = FHIRHelpers_4_3_000.ToValue(bv_);
					bool bx_ = bw_ is CqlInterval<CqlDateTime>;

					return bx_;
				};
				bool br_()
				{
					DataType by_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bz_ = FHIRHelpers_4_3_000.ToValue(by_);
					bool ca_ = bz_ is CqlDateTime;

					return ca_;
				};
				if (bp_())
				{
					DataType cb_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object cc_ = FHIRHelpers_4_3_000.ToValue(cb_);
					CqlDateTime cd_ = cc_ switch { null => null , CqlDateTime e => e/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return cd_ as object;
				}
				else if (bq_())
				{
					DataType ce_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object cf_ = FHIRHelpers_4_3_000.ToValue(ce_);
					CqlInterval<CqlDateTime> cg_ = cf_ switch { null => null , CqlInterval<CqlDateTime> f => f/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return cg_ as object;
				}
				else if (br_())
				{
					DataType ch_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object ci_ = FHIRHelpers_4_3_000.ToValue(ch_);
					CqlDateTime cj_ = ci_ switch { null => null , CqlDateTime g => g/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return cj_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime ai_ = QICoreCommon_2_0_000.Earliest(ah_());
			CqlQuantity aj_ = context.Operators.Quantity(24m, "hours");
			CqlDateTime ak_ = context.Operators.Subtract(ai_, aj_);
			object al_()
			{
				bool ck_()
				{
					DataType cn_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object co_ = FHIRHelpers_4_3_000.ToValue(cn_);
					bool cp_ = co_ is CqlDateTime;

					return cp_;
				};
				bool cl_()
				{
					DataType cq_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object cr_ = FHIRHelpers_4_3_000.ToValue(cq_);
					bool cs_ = cr_ is CqlInterval<CqlDateTime>;

					return cs_;
				};
				bool cm_()
				{
					DataType ct_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object cu_ = FHIRHelpers_4_3_000.ToValue(ct_);
					bool cv_ = cu_ is CqlDateTime;

					return cv_;
				};
				if (ck_())
				{
					DataType cw_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object cx_ = FHIRHelpers_4_3_000.ToValue(cw_);
					CqlDateTime cy_ = cx_ switch { null => null , CqlDateTime h => h/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return cy_ as object;
				}
				else if (cl_())
				{
					DataType cz_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object da_ = FHIRHelpers_4_3_000.ToValue(cz_);
					CqlInterval<CqlDateTime> db_ = da_ switch { null => null , CqlInterval<CqlDateTime> i => i/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return db_ as object;
				}
				else if (cm_())
				{
					DataType dc_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object dd_ = FHIRHelpers_4_3_000.ToValue(dc_);
					CqlDateTime de_ = dd_ switch { null => null , CqlDateTime j => j/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return de_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime am_ = QICoreCommon_2_0_000.Earliest(al_());
			CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ak_, am_, true, true);
			bool? ao_ = context.Operators.In<CqlDateTime>(ag_, an_, default);
			object ap_()
			{
				bool df_()
				{
					DataType di_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object dj_ = FHIRHelpers_4_3_000.ToValue(di_);
					bool dk_ = dj_ is CqlDateTime;

					return dk_;
				};
				bool dg_()
				{
					DataType dl_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object dm_ = FHIRHelpers_4_3_000.ToValue(dl_);
					bool dn_ = dm_ is CqlInterval<CqlDateTime>;

					return dn_;
				};
				bool dh_()
				{
					DataType do_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object dp_ = FHIRHelpers_4_3_000.ToValue(do_);
					bool dq_ = dp_ is CqlDateTime;

					return dq_;
				};
				if (df_())
				{
					DataType dr_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object ds_ = FHIRHelpers_4_3_000.ToValue(dr_);
					CqlDateTime dt_ = ds_ switch { null => null , CqlDateTime k => k/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return dt_ as object;
				}
				else if (dg_())
				{
					DataType du_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object dv_ = FHIRHelpers_4_3_000.ToValue(du_);
					CqlInterval<CqlDateTime> dw_ = dv_ switch { null => null , CqlInterval<CqlDateTime> l => l/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return dw_ as object;
				}
				else if (dh_())
				{
					DataType dx_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object dy_ = FHIRHelpers_4_3_000.ToValue(dx_);
					CqlDateTime dz_ = dy_ switch { null => null , CqlDateTime m => m/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return dz_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime aq_ = QICoreCommon_2_0_000.Earliest(ap_());
			bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
			bool? as_ = context.Operators.And(ao_, ar_);
			bool? at_ = context.Operators.And(ac_, as_);

			return at_;
		};
		IEnumerable<(Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> i_ = context.Operators.Where<(Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(g_, h_);
		Observation j_((Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_btymmdgachdragrhofgxbxgho) => 
			tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest;
		IEnumerable<Observation> k_ = context.Operators.Select<(Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?, Observation>(i_, j_);

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
		IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(c_, default);
		IEnumerable<ValueTuple<Encounter, Observation, Observation>> e_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, b_, d_);
		(Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? f_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
		{
			(Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? l_ = (_valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

			return l_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> g_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(e_, f_);
		bool? h_((Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_clljqcgdejtdiiewkzyjpwapd)
		{
			object m_()
			{
				bool be_()
				{
					DataType bh_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object bi_ = FHIRHelpers_4_3_000.ToValue(bh_);
					bool bj_ = bi_ is CqlDateTime;

					return bj_;
				};
				bool bf_()
				{
					DataType bk_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object bl_ = FHIRHelpers_4_3_000.ToValue(bk_);
					bool bm_ = bl_ is CqlInterval<CqlDateTime>;

					return bm_;
				};
				bool bg_()
				{
					DataType bn_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
					bool bp_ = bo_ is CqlDateTime;

					return bp_;
				};
				if (be_())
				{
					DataType bq_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
					CqlDateTime bs_ = br_ switch { null => null , CqlDateTime a => a/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bs_ as object;
				}
				else if (bf_())
				{
					DataType bt_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object bu_ = FHIRHelpers_4_3_000.ToValue(bt_);
					CqlInterval<CqlDateTime> bv_ = bu_ switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bv_ as object;
				}
				else if (bg_())
				{
					DataType bw_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object bx_ = FHIRHelpers_4_3_000.ToValue(bw_);
					CqlDateTime by_ = bx_ switch { null => null , CqlDateTime c => c/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return by_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime n_ = QICoreCommon_2_0_000.Earliest(m_());
			object o_()
			{
				bool bz_()
				{
					DataType cc_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cd_ = FHIRHelpers_4_3_000.ToValue(cc_);
					bool ce_ = cd_ is CqlDateTime;

					return ce_;
				};
				bool ca_()
				{
					DataType cf_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cg_ = FHIRHelpers_4_3_000.ToValue(cf_);
					bool ch_ = cg_ is CqlInterval<CqlDateTime>;

					return ch_;
				};
				bool cb_()
				{
					DataType ci_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cj_ = FHIRHelpers_4_3_000.ToValue(ci_);
					bool ck_ = cj_ is CqlDateTime;

					return ck_;
				};
				if (bz_())
				{
					DataType cl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cm_ = FHIRHelpers_4_3_000.ToValue(cl_);
					CqlDateTime cn_ = cm_ switch { null => null , CqlDateTime d => d/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return cn_ as object;
				}
				else if (ca_())
				{
					DataType co_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cp_ = FHIRHelpers_4_3_000.ToValue(co_);
					CqlInterval<CqlDateTime> cq_ = cp_ switch { null => null , CqlInterval<CqlDateTime> e => e/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return cq_ as object;
				}
				else if (cb_())
				{
					DataType cr_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cs_ = FHIRHelpers_4_3_000.ToValue(cr_);
					CqlDateTime ct_ = cs_ switch { null => null , CqlDateTime f => f/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ct_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime p_ = QICoreCommon_2_0_000.Earliest(o_());
			object q_()
			{
				bool cu_()
				{
					DataType cx_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cy_ = FHIRHelpers_4_3_000.ToValue(cx_);
					bool cz_ = cy_ is CqlDateTime;

					return cz_;
				};
				bool cv_()
				{
					DataType da_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object db_ = FHIRHelpers_4_3_000.ToValue(da_);
					bool dc_ = db_ is CqlInterval<CqlDateTime>;

					return dc_;
				};
				bool cw_()
				{
					DataType dd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object de_ = FHIRHelpers_4_3_000.ToValue(dd_);
					bool df_ = de_ is CqlDateTime;

					return df_;
				};
				if (cu_())
				{
					DataType dg_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object dh_ = FHIRHelpers_4_3_000.ToValue(dg_);
					CqlDateTime di_ = dh_ switch { null => null , CqlDateTime g => g/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return di_ as object;
				}
				else if (cv_())
				{
					DataType dj_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object dk_ = FHIRHelpers_4_3_000.ToValue(dj_);
					CqlInterval<CqlDateTime> dl_ = dk_ switch { null => null , CqlInterval<CqlDateTime> h => h/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return dl_ as object;
				}
				else if (cw_())
				{
					DataType dm_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object dn_ = FHIRHelpers_4_3_000.ToValue(dm_);
					CqlDateTime do_ = dn_ switch { null => null , CqlDateTime i => i/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return do_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime r_ = QICoreCommon_2_0_000.Earliest(q_());
			CqlQuantity s_ = context.Operators.Quantity(5m, "minutes");
			CqlDateTime t_ = context.Operators.Add(r_, s_);
			CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, t_, false, true);
			bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, default);
			object w_()
			{
				bool dp_()
				{
					DataType ds_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object dt_ = FHIRHelpers_4_3_000.ToValue(ds_);
					bool du_ = dt_ is CqlDateTime;

					return du_;
				};
				bool dq_()
				{
					DataType dv_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object dw_ = FHIRHelpers_4_3_000.ToValue(dv_);
					bool dx_ = dw_ is CqlInterval<CqlDateTime>;

					return dx_;
				};
				bool dr_()
				{
					DataType dy_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object dz_ = FHIRHelpers_4_3_000.ToValue(dy_);
					bool ea_ = dz_ is CqlDateTime;

					return ea_;
				};
				if (dp_())
				{
					DataType eb_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object ec_ = FHIRHelpers_4_3_000.ToValue(eb_);
					CqlDateTime ed_ = ec_ switch { null => null , CqlDateTime j => j/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ed_ as object;
				}
				else if (dq_())
				{
					DataType ee_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object ef_ = FHIRHelpers_4_3_000.ToValue(ee_);
					CqlInterval<CqlDateTime> eg_ = ef_ switch { null => null , CqlInterval<CqlDateTime> k => k/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return eg_ as object;
				}
				else if (dr_())
				{
					DataType eh_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object ei_ = FHIRHelpers_4_3_000.ToValue(eh_);
					CqlDateTime ej_ = ei_ switch { null => null , CqlDateTime l => l/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ej_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime x_ = QICoreCommon_2_0_000.Earliest(w_());
			bool? y_ = context.Operators.Not((bool?)(x_ is null));
			bool? z_ = context.Operators.And(v_, y_);
			object aa_()
			{
				bool ek_()
				{
					DataType en_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object eo_ = FHIRHelpers_4_3_000.ToValue(en_);
					bool ep_ = eo_ is CqlDateTime;

					return ep_;
				};
				bool el_()
				{
					DataType eq_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object er_ = FHIRHelpers_4_3_000.ToValue(eq_);
					bool es_ = er_ is CqlInterval<CqlDateTime>;

					return es_;
				};
				bool em_()
				{
					DataType et_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object eu_ = FHIRHelpers_4_3_000.ToValue(et_);
					bool ev_ = eu_ is CqlDateTime;

					return ev_;
				};
				if (ek_())
				{
					DataType ew_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object ex_ = FHIRHelpers_4_3_000.ToValue(ew_);
					CqlDateTime ey_ = ex_ switch { null => null , CqlDateTime m => m/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ey_ as object;
				}
				else if (el_())
				{
					DataType ez_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object fa_ = FHIRHelpers_4_3_000.ToValue(ez_);
					CqlInterval<CqlDateTime> fb_ = fa_ switch { null => null , CqlInterval<CqlDateTime> n => n/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return fb_ as object;
				}
				else if (em_())
				{
					DataType fc_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object fd_ = FHIRHelpers_4_3_000.ToValue(fc_);
					CqlDateTime fe_ = fd_ switch { null => null , CqlDateTime o => o/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return fe_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime ab_ = QICoreCommon_2_0_000.Earliest(aa_());
			CqlInterval<CqlDateTime> ac_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_clljqcgdejtdiiewkzyjpwapd?.QualifyingEncounter);
			bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, default);
			bool? ae_ = context.Operators.And(z_, ad_);
			object af_()
			{
				bool ff_()
				{
					DataType fi_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object fj_ = FHIRHelpers_4_3_000.ToValue(fi_);
					bool fk_ = fj_ is CqlDateTime;

					return fk_;
				};
				bool fg_()
				{
					DataType fl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object fm_ = FHIRHelpers_4_3_000.ToValue(fl_);
					bool fn_ = fm_ is CqlInterval<CqlDateTime>;

					return fn_;
				};
				bool fh_()
				{
					DataType fo_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object fp_ = FHIRHelpers_4_3_000.ToValue(fo_);
					bool fq_ = fp_ is CqlDateTime;

					return fq_;
				};
				if (ff_())
				{
					DataType fr_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object fs_ = FHIRHelpers_4_3_000.ToValue(fr_);
					CqlDateTime ft_ = fs_ switch { null => null , CqlDateTime p => p/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ft_ as object;
				}
				else if (fg_())
				{
					DataType fu_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object fv_ = FHIRHelpers_4_3_000.ToValue(fu_);
					CqlInterval<CqlDateTime> fw_ = fv_ switch { null => null , CqlInterval<CqlDateTime> q => q/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return fw_ as object;
				}
				else if (fh_())
				{
					DataType fx_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object fy_ = FHIRHelpers_4_3_000.ToValue(fx_);
					CqlDateTime fz_ = fy_ switch { null => null , CqlDateTime r => r/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return fz_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime ag_ = QICoreCommon_2_0_000.Earliest(af_());
			bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ac_, default);
			bool? aj_ = context.Operators.And(ae_, ai_);
			Id ak_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.IdElement;
			string al_ = ak_?.Value;
			Id am_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.IdElement;
			string an_ = am_?.Value;
			bool? ao_ = context.Operators.Equivalent(al_, an_);
			bool? ap_ = context.Operators.Not(ao_);
			bool? aq_ = context.Operators.And(aj_, ap_);
			Code<ObservationStatus> ar_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.StatusElement;
			ObservationStatus? as_ = ar_?.Value;
			Code<ObservationStatus> at_ = context.Operators.Convert<Code<ObservationStatus>>(as_);
			string au_ = context.Operators.Convert<string>(at_);
			string[] av_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? aw_ = context.Operators.In<string>(au_, av_ as IEnumerable<string>);
			bool? ax_ = context.Operators.And(aq_, aw_);
			DataType ay_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Value;
			object az_ = FHIRHelpers_4_3_000.ToValue(ay_);
			CqlQuantity ba_ = az_ switch { null => null , CqlQuantity s => s/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity bb_ = context.Operators.Quantity(80m, "mg/dL");
			bool? bc_ = context.Operators.Greater(ba_, bb_);
			bool? bd_ = context.Operators.And(ax_, bc_);

			return bd_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> i_ = context.Operators.Where<(Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(g_, h_);
		Observation j_((Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_clljqcgdejtdiiewkzyjpwapd) => 
			tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest;
		IEnumerable<Observation> k_ = context.Operators.Select<(Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?, Observation>(i_, j_);

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
			Id d_ = LowGlucoseTest?.IdElement;
			string e_ = d_?.Value;
			IEnumerable<Observation> f_ = this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80();
			bool? g_(Observation @this)
			{
				string m_ = (@this is Resource
	? (@this as Resource).IdElement
	: default)?.Value;
				bool? n_ = context.Operators.Not((bool?)(m_ is null));

				return n_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			string i_(Observation @this)
			{
				string o_ = (@this is Resource
	? (@this as Resource).IdElement
	: default)?.Value;

				return o_;
			};
			IEnumerable<string> j_ = context.Operators.Select<Observation, string>(h_, i_);
			bool? k_ = context.Operators.In<string>(e_, j_);
			bool? l_ = context.Operators.Not(k_);

			return l_;
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
		IEnumerable<ValueTuple<Encounter, Observation>> c_ = context.Operators.CrossJoin<Encounter, Observation>(a_, b_);
		(Encounter QualifyingEncounter, Observation HypoglycemicEvent)? d_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(Encounter QualifyingEncounter, Observation HypoglycemicEvent)? j_ = (_valueTuple.Item1, _valueTuple.Item2);

			return j_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation HypoglycemicEvent)?> e_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (Encounter QualifyingEncounter, Observation HypoglycemicEvent)?>(c_, d_);
		bool? f_((Encounter QualifyingEncounter, Observation HypoglycemicEvent)? tuple_hfnempjqliopfnrmypnydhffr)
		{
			object k_()
			{
				bool o_()
				{
					DataType r_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
					object s_ = FHIRHelpers_4_3_000.ToValue(r_);
					bool t_ = s_ is CqlDateTime;

					return t_;
				};
				bool p_()
				{
					DataType u_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
					object v_ = FHIRHelpers_4_3_000.ToValue(u_);
					bool w_ = v_ is CqlInterval<CqlDateTime>;

					return w_;
				};
				bool q_()
				{
					DataType x_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
					object y_ = FHIRHelpers_4_3_000.ToValue(x_);
					bool z_ = y_ is CqlDateTime;

					return z_;
				};
				if (o_())
				{
					DataType aa_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
					object ab_ = FHIRHelpers_4_3_000.ToValue(aa_);
					CqlDateTime ac_ = ab_ switch { null => null , CqlDateTime a => a/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ac_ as object;
				}
				else if (p_())
				{
					DataType ad_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
					object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
					CqlInterval<CqlDateTime> af_ = ae_ switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return af_ as object;
				}
				else if (q_())
				{
					DataType ag_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
					object ah_ = FHIRHelpers_4_3_000.ToValue(ag_);
					CqlDateTime ai_ = ah_ switch { null => null , CqlDateTime c => c/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ai_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime l_ = QICoreCommon_2_0_000.Earliest(k_());
			CqlInterval<CqlDateTime> m_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_hfnempjqliopfnrmypnydhffr?.QualifyingEncounter);
			bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);

			return n_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation HypoglycemicEvent)?> g_ = context.Operators.Where<(Encounter QualifyingEncounter, Observation HypoglycemicEvent)?>(e_, f_);
		Encounter h_((Encounter QualifyingEncounter, Observation HypoglycemicEvent)? tuple_hfnempjqliopfnrmypnydhffr) => 
			tuple_hfnempjqliopfnrmypnydhffr?.QualifyingEncounter;
		IEnumerable<Encounter> i_ = context.Operators.Select<(Encounter QualifyingEncounter, Observation HypoglycemicEvent)?, Encounter>(g_, h_);

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
