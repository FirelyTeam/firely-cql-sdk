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
				bool at_()
				{
					DataType aw_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
					bool ay_ = ax_ is CqlDateTime;

					return ay_;
				};
				bool au_()
				{
					DataType az_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object ba_ = FHIRHelpers_4_3_000.ToValue(az_);
					bool bb_ = ba_ is CqlInterval<CqlDateTime>;

					return bb_;
				};
				bool av_()
				{
					DataType bc_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bd_ = FHIRHelpers_4_3_000.ToValue(bc_);
					bool be_ = bd_ is CqlDateTime;

					return be_;
				};
				if (at_())
				{
					DataType bf_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bg_ = FHIRHelpers_4_3_000.ToValue(bf_);

					return (bg_ as CqlDateTime) as object;
				}
				else if (au_())
				{
					DataType bh_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bi_ = FHIRHelpers_4_3_000.ToValue(bh_);
					CqlInterval<CqlDateTime> bj_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(bi_);

					return bj_ as object;
				}
				else if (av_())
				{
					DataType bk_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bl_ = FHIRHelpers_4_3_000.ToValue(bk_);

					return (bl_ as CqlDateTime) as object;
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
			CqlQuantity z_ = context.Operators.Quantity(40m, "mg/dL");
			bool? aa_ = context.Operators.Less(y_ as CqlQuantity, z_);
			bool? ab_ = context.Operators.And(w_, aa_);
			DataType ac_ = tuple_btymmdgachdragrhofgxbxgho?.HypoglycemicMedication?.Effective;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval(ad_);
			CqlDateTime af_ = context.Operators.Start(ae_);
			object ag_()
			{
				bool bm_()
				{
					DataType bp_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bq_ = FHIRHelpers_4_3_000.ToValue(bp_);
					bool br_ = bq_ is CqlDateTime;

					return br_;
				};
				bool bn_()
				{
					DataType bs_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bt_ = FHIRHelpers_4_3_000.ToValue(bs_);
					bool bu_ = bt_ is CqlInterval<CqlDateTime>;

					return bu_;
				};
				bool bo_()
				{
					DataType bv_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bw_ = FHIRHelpers_4_3_000.ToValue(bv_);
					bool bx_ = bw_ is CqlDateTime;

					return bx_;
				};
				if (bm_())
				{
					DataType by_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object bz_ = FHIRHelpers_4_3_000.ToValue(by_);

					return (bz_ as CqlDateTime) as object;
				}
				else if (bn_())
				{
					DataType ca_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
					CqlInterval<CqlDateTime> cc_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(cb_);

					return cc_ as object;
				}
				else if (bo_())
				{
					DataType cd_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object ce_ = FHIRHelpers_4_3_000.ToValue(cd_);

					return (ce_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime ah_ = QICoreCommon_2_0_000.Earliest(ag_());
			CqlQuantity ai_ = context.Operators.Quantity(24m, "hours");
			CqlDateTime aj_ = context.Operators.Subtract(ah_, ai_);
			object ak_()
			{
				bool cf_()
				{
					DataType ci_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object cj_ = FHIRHelpers_4_3_000.ToValue(ci_);
					bool ck_ = cj_ is CqlDateTime;

					return ck_;
				};
				bool cg_()
				{
					DataType cl_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object cm_ = FHIRHelpers_4_3_000.ToValue(cl_);
					bool cn_ = cm_ is CqlInterval<CqlDateTime>;

					return cn_;
				};
				bool ch_()
				{
					DataType co_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object cp_ = FHIRHelpers_4_3_000.ToValue(co_);
					bool cq_ = cp_ is CqlDateTime;

					return cq_;
				};
				if (cf_())
				{
					DataType cr_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object cs_ = FHIRHelpers_4_3_000.ToValue(cr_);

					return (cs_ as CqlDateTime) as object;
				}
				else if (cg_())
				{
					DataType ct_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object cu_ = FHIRHelpers_4_3_000.ToValue(ct_);
					CqlInterval<CqlDateTime> cv_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(cu_);

					return cv_ as object;
				}
				else if (ch_())
				{
					DataType cw_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object cx_ = FHIRHelpers_4_3_000.ToValue(cw_);

					return (cx_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime al_ = QICoreCommon_2_0_000.Earliest(ak_());
			CqlInterval<CqlDateTime> am_ = context.Operators.Interval(aj_, al_, true, true);
			bool? an_ = context.Operators.In<CqlDateTime>(af_, am_, default);
			object ao_()
			{
				bool cy_()
				{
					DataType db_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object dc_ = FHIRHelpers_4_3_000.ToValue(db_);
					bool dd_ = dc_ is CqlDateTime;

					return dd_;
				};
				bool cz_()
				{
					DataType de_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object df_ = FHIRHelpers_4_3_000.ToValue(de_);
					bool dg_ = df_ is CqlInterval<CqlDateTime>;

					return dg_;
				};
				bool da_()
				{
					DataType dh_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object di_ = FHIRHelpers_4_3_000.ToValue(dh_);
					bool dj_ = di_ is CqlDateTime;

					return dj_;
				};
				if (cy_())
				{
					DataType dk_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object dl_ = FHIRHelpers_4_3_000.ToValue(dk_);

					return (dl_ as CqlDateTime) as object;
				}
				else if (cz_())
				{
					DataType dm_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object dn_ = FHIRHelpers_4_3_000.ToValue(dm_);
					CqlInterval<CqlDateTime> do_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(dn_);

					return do_ as object;
				}
				else if (da_())
				{
					DataType dp_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
					object dq_ = FHIRHelpers_4_3_000.ToValue(dp_);

					return (dq_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime ap_ = QICoreCommon_2_0_000.Earliest(ao_());
			bool? aq_ = context.Operators.Not((bool?)(ap_ is null));
			bool? ar_ = context.Operators.And(an_, aq_);
			bool? as_ = context.Operators.And(ab_, ar_);

			return as_;
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
				bool bd_()
				{
					DataType bg_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
					bool bi_ = bh_ is CqlDateTime;

					return bi_;
				};
				bool be_()
				{
					DataType bj_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object bk_ = FHIRHelpers_4_3_000.ToValue(bj_);
					bool bl_ = bk_ is CqlInterval<CqlDateTime>;

					return bl_;
				};
				bool bf_()
				{
					DataType bm_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object bn_ = FHIRHelpers_4_3_000.ToValue(bm_);
					bool bo_ = bn_ is CqlDateTime;

					return bo_;
				};
				if (bd_())
				{
					DataType bp_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object bq_ = FHIRHelpers_4_3_000.ToValue(bp_);

					return (bq_ as CqlDateTime) as object;
				}
				else if (be_())
				{
					DataType br_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object bs_ = FHIRHelpers_4_3_000.ToValue(br_);
					CqlInterval<CqlDateTime> bt_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(bs_);

					return bt_ as object;
				}
				else if (bf_())
				{
					DataType bu_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object bv_ = FHIRHelpers_4_3_000.ToValue(bu_);

					return (bv_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime n_ = QICoreCommon_2_0_000.Earliest(m_());
			object o_()
			{
				bool bw_()
				{
					DataType bz_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object ca_ = FHIRHelpers_4_3_000.ToValue(bz_);
					bool cb_ = ca_ is CqlDateTime;

					return cb_;
				};
				bool bx_()
				{
					DataType cc_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cd_ = FHIRHelpers_4_3_000.ToValue(cc_);
					bool ce_ = cd_ is CqlInterval<CqlDateTime>;

					return ce_;
				};
				bool by_()
				{
					DataType cf_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cg_ = FHIRHelpers_4_3_000.ToValue(cf_);
					bool ch_ = cg_ is CqlDateTime;

					return ch_;
				};
				if (bw_())
				{
					DataType ci_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cj_ = FHIRHelpers_4_3_000.ToValue(ci_);

					return (cj_ as CqlDateTime) as object;
				}
				else if (bx_())
				{
					DataType ck_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cl_ = FHIRHelpers_4_3_000.ToValue(ck_);
					CqlInterval<CqlDateTime> cm_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(cl_);

					return cm_ as object;
				}
				else if (by_())
				{
					DataType cn_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object co_ = FHIRHelpers_4_3_000.ToValue(cn_);

					return (co_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime p_ = QICoreCommon_2_0_000.Earliest(o_());
			object q_()
			{
				bool cp_()
				{
					DataType cs_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object ct_ = FHIRHelpers_4_3_000.ToValue(cs_);
					bool cu_ = ct_ is CqlDateTime;

					return cu_;
				};
				bool cq_()
				{
					DataType cv_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cw_ = FHIRHelpers_4_3_000.ToValue(cv_);
					bool cx_ = cw_ is CqlInterval<CqlDateTime>;

					return cx_;
				};
				bool cr_()
				{
					DataType cy_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object cz_ = FHIRHelpers_4_3_000.ToValue(cy_);
					bool da_ = cz_ is CqlDateTime;

					return da_;
				};
				if (cp_())
				{
					DataType db_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object dc_ = FHIRHelpers_4_3_000.ToValue(db_);

					return (dc_ as CqlDateTime) as object;
				}
				else if (cq_())
				{
					DataType dd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object de_ = FHIRHelpers_4_3_000.ToValue(dd_);
					CqlInterval<CqlDateTime> df_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(de_);

					return df_ as object;
				}
				else if (cr_())
				{
					DataType dg_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object dh_ = FHIRHelpers_4_3_000.ToValue(dg_);

					return (dh_ as CqlDateTime) as object;
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
				bool di_()
				{
					DataType dl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object dm_ = FHIRHelpers_4_3_000.ToValue(dl_);
					bool dn_ = dm_ is CqlDateTime;

					return dn_;
				};
				bool dj_()
				{
					DataType do_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object dp_ = FHIRHelpers_4_3_000.ToValue(do_);
					bool dq_ = dp_ is CqlInterval<CqlDateTime>;

					return dq_;
				};
				bool dk_()
				{
					DataType dr_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object ds_ = FHIRHelpers_4_3_000.ToValue(dr_);
					bool dt_ = ds_ is CqlDateTime;

					return dt_;
				};
				if (di_())
				{
					DataType du_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object dv_ = FHIRHelpers_4_3_000.ToValue(du_);

					return (dv_ as CqlDateTime) as object;
				}
				else if (dj_())
				{
					DataType dw_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object dx_ = FHIRHelpers_4_3_000.ToValue(dw_);
					CqlInterval<CqlDateTime> dy_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(dx_);

					return dy_ as object;
				}
				else if (dk_())
				{
					DataType dz_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object ea_ = FHIRHelpers_4_3_000.ToValue(dz_);

					return (ea_ as CqlDateTime) as object;
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
				bool eb_()
				{
					DataType ee_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object ef_ = FHIRHelpers_4_3_000.ToValue(ee_);
					bool eg_ = ef_ is CqlDateTime;

					return eg_;
				};
				bool ec_()
				{
					DataType eh_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object ei_ = FHIRHelpers_4_3_000.ToValue(eh_);
					bool ej_ = ei_ is CqlInterval<CqlDateTime>;

					return ej_;
				};
				bool ed_()
				{
					DataType ek_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object el_ = FHIRHelpers_4_3_000.ToValue(ek_);
					bool em_ = el_ is CqlDateTime;

					return em_;
				};
				if (eb_())
				{
					DataType en_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object eo_ = FHIRHelpers_4_3_000.ToValue(en_);

					return (eo_ as CqlDateTime) as object;
				}
				else if (ec_())
				{
					DataType ep_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object eq_ = FHIRHelpers_4_3_000.ToValue(ep_);
					CqlInterval<CqlDateTime> er_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(eq_);

					return er_ as object;
				}
				else if (ed_())
				{
					DataType es_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
					object et_ = FHIRHelpers_4_3_000.ToValue(es_);

					return (et_ as CqlDateTime) as object;
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
				bool eu_()
				{
					DataType ex_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object ey_ = FHIRHelpers_4_3_000.ToValue(ex_);
					bool ez_ = ey_ is CqlDateTime;

					return ez_;
				};
				bool ev_()
				{
					DataType fa_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object fb_ = FHIRHelpers_4_3_000.ToValue(fa_);
					bool fc_ = fb_ is CqlInterval<CqlDateTime>;

					return fc_;
				};
				bool ew_()
				{
					DataType fd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object fe_ = FHIRHelpers_4_3_000.ToValue(fd_);
					bool ff_ = fe_ is CqlDateTime;

					return ff_;
				};
				if (eu_())
				{
					DataType fg_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object fh_ = FHIRHelpers_4_3_000.ToValue(fg_);

					return (fh_ as CqlDateTime) as object;
				}
				else if (ev_())
				{
					DataType fi_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object fj_ = FHIRHelpers_4_3_000.ToValue(fi_);
					CqlInterval<CqlDateTime> fk_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(fj_);

					return fk_ as object;
				}
				else if (ew_())
				{
					DataType fl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
					object fm_ = FHIRHelpers_4_3_000.ToValue(fl_);

					return (fm_ as CqlDateTime) as object;
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
			CqlQuantity ba_ = context.Operators.Quantity(80m, "mg/dL");
			bool? bb_ = context.Operators.Greater(az_ as CqlQuantity, ba_);
			bool? bc_ = context.Operators.And(ax_, bb_);

			return bc_;
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

					return (ab_ as CqlDateTime) as object;
				}
				else if (p_())
				{
					DataType ac_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
					object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
					CqlInterval<CqlDateTime> ae_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(ad_);

					return ae_ as object;
				}
				else if (q_())
				{
					DataType af_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
					object ag_ = FHIRHelpers_4_3_000.ToValue(af_);

					return (ag_ as CqlDateTime) as object;
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
