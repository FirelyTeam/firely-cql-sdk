﻿using System;
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
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Value()
	{
		var a_ = this.Hypoglycemics_Severe_Hypoglycemia();
		var b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration HypoMedication)
		{
			var h_ = HypoMedication?.StatusElement;
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
				var i_ = HypoglycemicMedication?.Effective;
				var j_ = FHIRHelpers_4_3_000.ToValue(i_);
				var k_ = QICoreCommon_2_0_000.ToInterval(j_);
				var l_ = context.Operators.Start(k_);
				var m_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				var n_ = context.Operators.In<CqlDateTime>(l_, m_, null);

				return n_;
			};
			var f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
			Encounter g_(MedicationAdministration HypoglycemicMedication) => 
				InpatientHospitalization;
			var h_ = context.Operators.Select<MedicationAdministration, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

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
		var b_ = this.Hypoglycemic_Medication_Administration();
		var c_ = this.Glucose_Lab_Test_Mass_Per_Volume();
		var d_ = context.Operators.RetrieveByValueSet<Observation>(c_, null);
		var e_ = context.Operators.CrossJoin<Encounter, MedicationAdministration, Observation>(a_, b_, d_);
		Tuple_BTYMMDGaChdRaGRhOfgXBXGHO f_(ValueTuple<Encounter, MedicationAdministration, Observation> _valueTuple)
		{
			var l_ = new Tuple_BTYMMDGaChdRaGRhOfgXBXGHO
			{
				QualifyingEncounter = _valueTuple.Item1,
				HypoglycemicMedication = _valueTuple.Item2,
				GlucoseTest = _valueTuple.Item3,
			};

			return l_;
		};
		var g_ = context.Operators.Select<ValueTuple<Encounter, MedicationAdministration, Observation>, Tuple_BTYMMDGaChdRaGRhOfgXBXGHO>(e_, f_);
		bool? h_(Tuple_BTYMMDGaChdRaGRhOfgXBXGHO tuple_btymmdgachdragrhofgxbxgho)
		{
			object m_()
			{
				bool at_()
				{
					var aw_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
					var ay_ = ax_ is CqlDateTime;

					return ay_;
				};
				bool au_()
				{
					var az_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var ba_ = FHIRHelpers_4_3_000.ToValue(az_);
					var bb_ = ba_ is CqlInterval<CqlDateTime>;

					return bb_;
				};
				bool av_()
				{
					var bc_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var bd_ = FHIRHelpers_4_3_000.ToValue(bc_);
					var be_ = bd_ is CqlDateTime;

					return be_;
				};
				if (at_())
				{
					var bf_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var bg_ = FHIRHelpers_4_3_000.ToValue(bf_);

					return ((bg_ as CqlDateTime) as object);
				}
				else if (au_())
				{
					var bh_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var bi_ = FHIRHelpers_4_3_000.ToValue(bh_);

					return ((bi_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (av_())
				{
					var bj_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var bk_ = FHIRHelpers_4_3_000.ToValue(bj_);

					return ((bk_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var n_ = QICoreCommon_2_0_000.Earliest(m_());
			var o_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_btymmdgachdragrhofgxbxgho.QualifyingEncounter);
			var p_ = context.Operators.In<CqlDateTime>(n_, o_, null);
			var q_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.StatusElement;
			var r_ = q_?.Value;
			var s_ = context.Operators.Convert<Code<ObservationStatus>>(r_);
			var t_ = context.Operators.Convert<string>(s_);
			var u_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var v_ = context.Operators.In<string>(t_, (u_ as IEnumerable<string>));
			var w_ = context.Operators.And(p_, v_);
			var x_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Value;
			var y_ = FHIRHelpers_4_3_000.ToValue(x_);
			var z_ = context.Operators.Quantity(40m, "mg/dL");
			var aa_ = context.Operators.Less((y_ as CqlQuantity), z_);
			var ab_ = context.Operators.And(w_, aa_);
			var ac_ = tuple_btymmdgachdragrhofgxbxgho.HypoglycemicMedication?.Effective;
			var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var ae_ = QICoreCommon_2_0_000.ToInterval(ad_);
			var af_ = context.Operators.Start(ae_);
			object ag_()
			{
				bool bl_()
				{
					var bo_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var bp_ = FHIRHelpers_4_3_000.ToValue(bo_);
					var bq_ = bp_ is CqlDateTime;

					return bq_;
				};
				bool bm_()
				{
					var br_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var bs_ = FHIRHelpers_4_3_000.ToValue(br_);
					var bt_ = bs_ is CqlInterval<CqlDateTime>;

					return bt_;
				};
				bool bn_()
				{
					var bu_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var bv_ = FHIRHelpers_4_3_000.ToValue(bu_);
					var bw_ = bv_ is CqlDateTime;

					return bw_;
				};
				if (bl_())
				{
					var bx_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var by_ = FHIRHelpers_4_3_000.ToValue(bx_);

					return ((by_ as CqlDateTime) as object);
				}
				else if (bm_())
				{
					var bz_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var ca_ = FHIRHelpers_4_3_000.ToValue(bz_);

					return ((ca_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bn_())
				{
					var cb_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var cc_ = FHIRHelpers_4_3_000.ToValue(cb_);

					return ((cc_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var ah_ = QICoreCommon_2_0_000.Earliest(ag_());
			var ai_ = context.Operators.Quantity(24m, "hours");
			var aj_ = context.Operators.Subtract(ah_, ai_);
			object ak_()
			{
				bool cd_()
				{
					var cg_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var ch_ = FHIRHelpers_4_3_000.ToValue(cg_);
					var ci_ = ch_ is CqlDateTime;

					return ci_;
				};
				bool ce_()
				{
					var cj_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var ck_ = FHIRHelpers_4_3_000.ToValue(cj_);
					var cl_ = ck_ is CqlInterval<CqlDateTime>;

					return cl_;
				};
				bool cf_()
				{
					var cm_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var cn_ = FHIRHelpers_4_3_000.ToValue(cm_);
					var co_ = cn_ is CqlDateTime;

					return co_;
				};
				if (cd_())
				{
					var cp_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var cq_ = FHIRHelpers_4_3_000.ToValue(cp_);

					return ((cq_ as CqlDateTime) as object);
				}
				else if (ce_())
				{
					var cr_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var cs_ = FHIRHelpers_4_3_000.ToValue(cr_);

					return ((cs_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (cf_())
				{
					var ct_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var cu_ = FHIRHelpers_4_3_000.ToValue(ct_);

					return ((cu_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var al_ = QICoreCommon_2_0_000.Earliest(ak_());
			var am_ = context.Operators.Interval(aj_, al_, true, true);
			var an_ = context.Operators.In<CqlDateTime>(af_, am_, null);
			object ao_()
			{
				bool cv_()
				{
					var cy_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var cz_ = FHIRHelpers_4_3_000.ToValue(cy_);
					var da_ = cz_ is CqlDateTime;

					return da_;
				};
				bool cw_()
				{
					var db_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var dc_ = FHIRHelpers_4_3_000.ToValue(db_);
					var dd_ = dc_ is CqlInterval<CqlDateTime>;

					return dd_;
				};
				bool cx_()
				{
					var de_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var df_ = FHIRHelpers_4_3_000.ToValue(de_);
					var dg_ = df_ is CqlDateTime;

					return dg_;
				};
				if (cv_())
				{
					var dh_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var di_ = FHIRHelpers_4_3_000.ToValue(dh_);

					return ((di_ as CqlDateTime) as object);
				}
				else if (cw_())
				{
					var dj_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var dk_ = FHIRHelpers_4_3_000.ToValue(dj_);

					return ((dk_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (cx_())
				{
					var dl_ = tuple_btymmdgachdragrhofgxbxgho.GlucoseTest?.Effective;
					var dm_ = FHIRHelpers_4_3_000.ToValue(dl_);

					return ((dm_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var ap_ = QICoreCommon_2_0_000.Earliest(ao_());
			var aq_ = context.Operators.Not((bool?)(ap_ is null));
			var ar_ = context.Operators.And(an_, aq_);
			var as_ = context.Operators.And(ab_, ar_);

			return as_;
		};
		var i_ = context.Operators.Where<Tuple_BTYMMDGaChdRaGRhOfgXBXGHO>(g_, h_);
		Observation j_(Tuple_BTYMMDGaChdRaGRhOfgXBXGHO tuple_btymmdgachdragrhofgxbxgho) => 
			tuple_btymmdgachdragrhofgxbxgho.GlucoseTest;
		var k_ = context.Operators.Select<Tuple_BTYMMDGaChdRaGRhOfgXBXGHO, Observation>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Glucose Test with Result Less Than 40")]
	public IEnumerable<Observation> Glucose_Test_with_Result_Less_Than_40() => 
		__Glucose_Test_with_Result_Less_Than_40.Value;

	private IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80_Value()
	{
		var a_ = this.Denominator();
		var b_ = this.Glucose_Test_with_Result_Less_Than_40();
		var c_ = this.Glucose_Lab_Test_Mass_Per_Volume();
		var d_ = context.Operators.RetrieveByValueSet<Observation>(c_, null);
		var e_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, b_, d_);
		Tuple_CLLJQcGdEjTDiIeWKZYJPWaPd f_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
		{
			var l_ = new Tuple_CLLJQcGdEjTDiIeWKZYJPWaPd
			{
				QualifyingEncounter = _valueTuple.Item1,
				LowGlucoseTest = _valueTuple.Item2,
				FollowupGlucoseTest = _valueTuple.Item3,
			};

			return l_;
		};
		var g_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, Tuple_CLLJQcGdEjTDiIeWKZYJPWaPd>(e_, f_);
		bool? h_(Tuple_CLLJQcGdEjTDiIeWKZYJPWaPd tuple_clljqcgdejtdiiewkzyjpwapd)
		{
			object m_()
			{
				bool bd_()
				{
					var bg_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Effective;
					var bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
					var bi_ = bh_ is CqlDateTime;

					return bi_;
				};
				bool be_()
				{
					var bj_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Effective;
					var bk_ = FHIRHelpers_4_3_000.ToValue(bj_);
					var bl_ = bk_ is CqlInterval<CqlDateTime>;

					return bl_;
				};
				bool bf_()
				{
					var bm_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Effective;
					var bn_ = FHIRHelpers_4_3_000.ToValue(bm_);
					var bo_ = bn_ is CqlDateTime;

					return bo_;
				};
				if (bd_())
				{
					var bp_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Effective;
					var bq_ = FHIRHelpers_4_3_000.ToValue(bp_);

					return ((bq_ as CqlDateTime) as object);
				}
				else if (be_())
				{
					var br_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Effective;
					var bs_ = FHIRHelpers_4_3_000.ToValue(br_);

					return ((bs_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bf_())
				{
					var bt_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Effective;
					var bu_ = FHIRHelpers_4_3_000.ToValue(bt_);

					return ((bu_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var n_ = QICoreCommon_2_0_000.Earliest(m_());
			object o_()
			{
				bool bv_()
				{
					var by_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var bz_ = FHIRHelpers_4_3_000.ToValue(by_);
					var ca_ = bz_ is CqlDateTime;

					return ca_;
				};
				bool bw_()
				{
					var cb_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var cc_ = FHIRHelpers_4_3_000.ToValue(cb_);
					var cd_ = cc_ is CqlInterval<CqlDateTime>;

					return cd_;
				};
				bool bx_()
				{
					var ce_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var cf_ = FHIRHelpers_4_3_000.ToValue(ce_);
					var cg_ = cf_ is CqlDateTime;

					return cg_;
				};
				if (bv_())
				{
					var ch_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var ci_ = FHIRHelpers_4_3_000.ToValue(ch_);

					return ((ci_ as CqlDateTime) as object);
				}
				else if (bw_())
				{
					var cj_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var ck_ = FHIRHelpers_4_3_000.ToValue(cj_);

					return ((ck_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bx_())
				{
					var cl_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var cm_ = FHIRHelpers_4_3_000.ToValue(cl_);

					return ((cm_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var p_ = QICoreCommon_2_0_000.Earliest(o_());
			object q_()
			{
				bool cn_()
				{
					var cq_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var cr_ = FHIRHelpers_4_3_000.ToValue(cq_);
					var cs_ = cr_ is CqlDateTime;

					return cs_;
				};
				bool co_()
				{
					var ct_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var cu_ = FHIRHelpers_4_3_000.ToValue(ct_);
					var cv_ = cu_ is CqlInterval<CqlDateTime>;

					return cv_;
				};
				bool cp_()
				{
					var cw_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var cx_ = FHIRHelpers_4_3_000.ToValue(cw_);
					var cy_ = cx_ is CqlDateTime;

					return cy_;
				};
				if (cn_())
				{
					var cz_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var da_ = FHIRHelpers_4_3_000.ToValue(cz_);

					return ((da_ as CqlDateTime) as object);
				}
				else if (co_())
				{
					var db_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var dc_ = FHIRHelpers_4_3_000.ToValue(db_);

					return ((dc_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (cp_())
				{
					var dd_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var de_ = FHIRHelpers_4_3_000.ToValue(dd_);

					return ((de_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var r_ = QICoreCommon_2_0_000.Earliest(q_());
			var s_ = context.Operators.Quantity(5m, "minutes");
			var t_ = context.Operators.Add(r_, s_);
			var u_ = context.Operators.Interval(p_, t_, false, true);
			var v_ = context.Operators.In<CqlDateTime>(n_, u_, null);
			object w_()
			{
				bool df_()
				{
					var di_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var dj_ = FHIRHelpers_4_3_000.ToValue(di_);
					var dk_ = dj_ is CqlDateTime;

					return dk_;
				};
				bool dg_()
				{
					var dl_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var dm_ = FHIRHelpers_4_3_000.ToValue(dl_);
					var dn_ = dm_ is CqlInterval<CqlDateTime>;

					return dn_;
				};
				bool dh_()
				{
					var do_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var dp_ = FHIRHelpers_4_3_000.ToValue(do_);
					var dq_ = dp_ is CqlDateTime;

					return dq_;
				};
				if (df_())
				{
					var dr_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var ds_ = FHIRHelpers_4_3_000.ToValue(dr_);

					return ((ds_ as CqlDateTime) as object);
				}
				else if (dg_())
				{
					var dt_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var du_ = FHIRHelpers_4_3_000.ToValue(dt_);

					return ((du_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (dh_())
				{
					var dv_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var dw_ = FHIRHelpers_4_3_000.ToValue(dv_);

					return ((dw_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var x_ = QICoreCommon_2_0_000.Earliest(w_());
			var y_ = context.Operators.Not((bool?)(x_ is null));
			var z_ = context.Operators.And(v_, y_);
			object aa_()
			{
				bool dx_()
				{
					var ea_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var eb_ = FHIRHelpers_4_3_000.ToValue(ea_);
					var ec_ = eb_ is CqlDateTime;

					return ec_;
				};
				bool dy_()
				{
					var ed_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var ee_ = FHIRHelpers_4_3_000.ToValue(ed_);
					var ef_ = ee_ is CqlInterval<CqlDateTime>;

					return ef_;
				};
				bool dz_()
				{
					var eg_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var eh_ = FHIRHelpers_4_3_000.ToValue(eg_);
					var ei_ = eh_ is CqlDateTime;

					return ei_;
				};
				if (dx_())
				{
					var ej_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var ek_ = FHIRHelpers_4_3_000.ToValue(ej_);

					return ((ek_ as CqlDateTime) as object);
				}
				else if (dy_())
				{
					var el_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var em_ = FHIRHelpers_4_3_000.ToValue(el_);

					return ((em_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (dz_())
				{
					var en_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.Effective;
					var eo_ = FHIRHelpers_4_3_000.ToValue(en_);

					return ((eo_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var ab_ = QICoreCommon_2_0_000.Earliest(aa_());
			var ac_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_clljqcgdejtdiiewkzyjpwapd.QualifyingEncounter);
			var ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, null);
			var ae_ = context.Operators.And(z_, ad_);
			object af_()
			{
				bool ep_()
				{
					var es_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Effective;
					var et_ = FHIRHelpers_4_3_000.ToValue(es_);
					var eu_ = et_ is CqlDateTime;

					return eu_;
				};
				bool eq_()
				{
					var ev_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Effective;
					var ew_ = FHIRHelpers_4_3_000.ToValue(ev_);
					var ex_ = ew_ is CqlInterval<CqlDateTime>;

					return ex_;
				};
				bool er_()
				{
					var ey_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Effective;
					var ez_ = FHIRHelpers_4_3_000.ToValue(ey_);
					var fa_ = ez_ is CqlDateTime;

					return fa_;
				};
				if (ep_())
				{
					var fb_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Effective;
					var fc_ = FHIRHelpers_4_3_000.ToValue(fb_);

					return ((fc_ as CqlDateTime) as object);
				}
				else if (eq_())
				{
					var fd_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Effective;
					var fe_ = FHIRHelpers_4_3_000.ToValue(fd_);

					return ((fe_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (er_())
				{
					var ff_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Effective;
					var fg_ = FHIRHelpers_4_3_000.ToValue(ff_);

					return ((fg_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var ag_ = QICoreCommon_2_0_000.Earliest(af_());
			var ai_ = context.Operators.In<CqlDateTime>(ag_, ac_, null);
			var aj_ = context.Operators.And(ae_, ai_);
			var ak_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.IdElement;
			var al_ = ak_?.Value;
			var am_ = tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest?.IdElement;
			var an_ = am_?.Value;
			var ao_ = context.Operators.Equivalent(al_, an_);
			var ap_ = context.Operators.Not(ao_);
			var aq_ = context.Operators.And(aj_, ap_);
			var ar_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.StatusElement;
			var as_ = ar_?.Value;
			var at_ = context.Operators.Convert<Code<ObservationStatus>>(as_);
			var au_ = context.Operators.Convert<string>(at_);
			var av_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var aw_ = context.Operators.In<string>(au_, (av_ as IEnumerable<string>));
			var ax_ = context.Operators.And(aq_, aw_);
			var ay_ = tuple_clljqcgdejtdiiewkzyjpwapd.FollowupGlucoseTest?.Value;
			var az_ = FHIRHelpers_4_3_000.ToValue(ay_);
			var ba_ = context.Operators.Quantity(80m, "mg/dL");
			var bb_ = context.Operators.Greater((az_ as CqlQuantity), ba_);
			var bc_ = context.Operators.And(ax_, bb_);

			return bc_;
		};
		var i_ = context.Operators.Where<Tuple_CLLJQcGdEjTDiIeWKZYJPWaPd>(g_, h_);
		Observation j_(Tuple_CLLJQcGdEjTDiIeWKZYJPWaPd tuple_clljqcgdejtdiiewkzyjpwapd) => 
			tuple_clljqcgdejtdiiewkzyjpwapd.LowGlucoseTest;
		var k_ = context.Operators.Select<Tuple_CLLJQcGdEjTDiIeWKZYJPWaPd, Observation>(i_, j_);

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
			var d_ = LowGlucoseTest?.IdElement;
			var e_ = d_?.Value;
			var f_ = this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80();
			bool? g_(Observation @this)
			{
				var m_ = ((@this is Resource)
	? ((@this as Resource).IdElement)
	: null)?.Value;
				var n_ = context.Operators.Not((bool?)(m_ is null));

				return n_;
			};
			var h_ = context.Operators.Where<Observation>(f_, g_);
			string i_(Observation @this)
			{
				var o_ = ((@this is Resource)
	? ((@this as Resource).IdElement)
	: null)?.Value;

				return o_;
			};
			var j_ = context.Operators.Select<Observation, string>(h_, i_);
			var k_ = context.Operators.In<string>(e_, j_);
			var l_ = context.Operators.Not(k_);

			return l_;
		};
		var c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Severe Hypoglycemic Harm Event")]
	public IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event() => 
		__Severe_Hypoglycemic_Harm_Event.Value;

	private IEnumerable<Encounter> Encounter_with_Severe_Hypoglycemic_Harm_Event_Value()
	{
		var a_ = this.Denominator();
		var b_ = this.Severe_Hypoglycemic_Harm_Event();
		var c_ = context.Operators.CrossJoin<Encounter, Observation>(a_, b_);
		Tuple_HFNEMPjQLiOPFNRMYPNYDhFfR d_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			var j_ = new Tuple_HFNEMPjQLiOPFNRMYPNYDhFfR
			{
				QualifyingEncounter = _valueTuple.Item1,
				HypoglycemicEvent = _valueTuple.Item2,
			};

			return j_;
		};
		var e_ = context.Operators.Select<ValueTuple<Encounter, Observation>, Tuple_HFNEMPjQLiOPFNRMYPNYDhFfR>(c_, d_);
		bool? f_(Tuple_HFNEMPjQLiOPFNRMYPNYDhFfR tuple_hfnempjqliopfnrmypnydhffr)
		{
			object k_()
			{
				bool o_()
				{
					var r_ = tuple_hfnempjqliopfnrmypnydhffr.HypoglycemicEvent?.Effective;
					var s_ = FHIRHelpers_4_3_000.ToValue(r_);
					var t_ = s_ is CqlDateTime;

					return t_;
				};
				bool p_()
				{
					var u_ = tuple_hfnempjqliopfnrmypnydhffr.HypoglycemicEvent?.Effective;
					var v_ = FHIRHelpers_4_3_000.ToValue(u_);
					var w_ = v_ is CqlInterval<CqlDateTime>;

					return w_;
				};
				bool q_()
				{
					var x_ = tuple_hfnempjqliopfnrmypnydhffr.HypoglycemicEvent?.Effective;
					var y_ = FHIRHelpers_4_3_000.ToValue(x_);
					var z_ = y_ is CqlDateTime;

					return z_;
				};
				if (o_())
				{
					var aa_ = tuple_hfnempjqliopfnrmypnydhffr.HypoglycemicEvent?.Effective;
					var ab_ = FHIRHelpers_4_3_000.ToValue(aa_);

					return ((ab_ as CqlDateTime) as object);
				}
				else if (p_())
				{
					var ac_ = tuple_hfnempjqliopfnrmypnydhffr.HypoglycemicEvent?.Effective;
					var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);

					return ((ad_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (q_())
				{
					var ae_ = tuple_hfnempjqliopfnrmypnydhffr.HypoglycemicEvent?.Effective;
					var af_ = FHIRHelpers_4_3_000.ToValue(ae_);

					return ((af_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var l_ = QICoreCommon_2_0_000.Earliest(k_());
			var m_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_hfnempjqliopfnrmypnydhffr.QualifyingEncounter);
			var n_ = context.Operators.In<CqlDateTime>(l_, m_, null);

			return n_;
		};
		var g_ = context.Operators.Where<Tuple_HFNEMPjQLiOPFNRMYPNYDhFfR>(e_, f_);
		Encounter h_(Tuple_HFNEMPjQLiOPFNRMYPNYDhFfR tuple_hfnempjqliopfnrmypnydhffr) => 
			tuple_hfnempjqliopfnrmypnydhffr.QualifyingEncounter;
		var i_ = context.Operators.Select<Tuple_HFNEMPjQLiOPFNRMYPNYDhFfR, Encounter>(g_, h_);

		return i_;
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