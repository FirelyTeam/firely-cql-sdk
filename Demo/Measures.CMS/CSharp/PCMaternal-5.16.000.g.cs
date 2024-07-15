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
[CqlLibrary("PCMaternal", "5.16.000")]
public class PCMaternal_5_16_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Delivery_Procedures;
    internal Lazy<CqlValueSet> __ED_Visit_and_OB_Triage;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Estimated_Gestational_Age_at_Delivery;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlCode> __Date_and_time_of_obstetric_delivery;
    internal Lazy<CqlCode> __Delivery_date_Estimated;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Age_Range;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounter_with_Age_Range;
    internal Lazy<IEnumerable<Tuple_QRZgNJCaGQEYIeOSBhjLZNSO>> __Variable_Calculated_Gestational_Age;

    #endregion
    public PCMaternal_5_16_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Delivery_Procedures = new Lazy<CqlValueSet>(this.Delivery_Procedures_Value);
        __ED_Visit_and_OB_Triage = new Lazy<CqlValueSet>(this.ED_Visit_and_OB_Triage_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Estimated_Gestational_Age_at_Delivery = new Lazy<CqlValueSet>(this.Estimated_Gestational_Age_at_Delivery_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Date_and_time_of_obstetric_delivery = new Lazy<CqlCode>(this.Date_and_time_of_obstetric_delivery_Value);
        __Delivery_date_Estimated = new Lazy<CqlCode>(this.Delivery_date_Estimated_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Encounter_with_Age_Range = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Age_Range_Value);
        __Delivery_Encounter_with_Age_Range = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounter_with_Age_Range_Value);
        __Variable_Calculated_Gestational_Age = new Lazy<IEnumerable<Tuple_QRZgNJCaGQEYIeOSBhjLZNSO>>(this.Variable_Calculated_Gestational_Age_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Delivery_Procedures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", null);

    [CqlDeclaration("Delivery Procedures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59")]
	public CqlValueSet Delivery_Procedures() => 
		__Delivery_Procedures.Value;

	private CqlValueSet ED_Visit_and_OB_Triage_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", null);

    [CqlDeclaration("ED Visit and OB Triage")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369")]
	public CqlValueSet ED_Visit_and_OB_Triage() => 
		__ED_Visit_and_OB_Triage.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Estimated_Gestational_Age_at_Delivery_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26", null);

    [CqlDeclaration("Estimated Gestational Age at Delivery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26")]
	public CqlValueSet Estimated_Gestational_Age_at_Delivery() => 
		__Estimated_Gestational_Age_at_Delivery.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlCode Date_and_time_of_obstetric_delivery_Value() => 
		new CqlCode("93857-1", "http://loinc.org", null, null);

    [CqlDeclaration("Date and time of obstetric delivery")]
	public CqlCode Date_and_time_of_obstetric_delivery() => 
		__Date_and_time_of_obstetric_delivery.Value;

	private CqlCode Delivery_date_Estimated_Value() => 
		new CqlCode("11778-8", "http://loinc.org", null, null);

    [CqlDeclaration("Delivery date Estimated")]
	public CqlCode Delivery_date_Estimated() => 
		__Delivery_date_Estimated.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("93857-1", "http://loinc.org", null, null),
			new CqlCode("11778-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("PCMaternal-5.16.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Encounter_with_Age_Range_Value()
	{
		var a_ = CQMCommon_2_0_000.Inpatient_Encounter();
		bool? b_(Encounter InpatientEncounter)
		{
			var d_ = this.Patient();
			var e_ = d_?.BirthDateElement;
			var f_ = e_?.Value;
			var g_ = context.Operators.ConvertStringToDate(f_);
			var h_ = InpatientEncounter?.Period;
			var i_ = FHIRHelpers_4_3_000.ToInterval(h_);
			var j_ = context.Operators.Start(i_);
			var k_ = context.Operators.DateFrom(j_);
			var l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
			var m_ = context.Operators.Interval(8, 65, true, false);
			var n_ = context.Operators.In<int?>(l_, m_, null);

			return n_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Age Range")]
	public IEnumerable<Encounter> Encounter_with_Age_Range() => 
		__Encounter_with_Age_Range.Value;

    [CqlDeclaration("hospitalizationWithEDOBTriageObservation")]
	public CqlInterval<CqlDateTime> hospitalizationWithEDOBTriageObservation(Encounter TheEncounter)
	{
		var a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			var e_ = this.ED_Visit_and_OB_Triage();
			var f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastEDOBTriage)
			{
				var af_ = LastEDOBTriage?.Period;
				var ag_ = FHIRHelpers_4_3_000.ToInterval(af_);
				var ah_ = context.Operators.End(ag_);
				var ai_ = this.Observation_Services();
				var aj_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, null);
				bool? ak_(Encounter LastObs)
				{
					var cg_ = LastObs?.Period;
					var ch_ = FHIRHelpers_4_3_000.ToInterval(cg_);
					var ci_ = context.Operators.End(ch_);
					var cj_ = Visit?.Period;
					var ck_ = FHIRHelpers_4_3_000.ToInterval(cj_);
					var cl_ = context.Operators.Start(ck_);
					var cm_ = context.Operators.Quantity(1m, "hour");
					var cn_ = context.Operators.Subtract(cl_, cm_);
					var cp_ = FHIRHelpers_4_3_000.ToInterval(cj_);
					var cq_ = context.Operators.Start(cp_);
					var cr_ = context.Operators.Interval(cn_, cq_, true, true);
					var cs_ = context.Operators.In<CqlDateTime>(ci_, cr_, null);
					var cu_ = FHIRHelpers_4_3_000.ToInterval(cj_);
					var cv_ = context.Operators.Start(cu_);
					var cw_ = context.Operators.Not((bool?)(cv_ is null));
					var cx_ = context.Operators.And(cs_, cw_);
					var cy_ = LastObs?.StatusElement;
					var cz_ = cy_?.Value;
					var da_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cz_);
					var db_ = context.Operators.Equal(da_, "finished");
					var dc_ = context.Operators.And(cx_, db_);

					return dc_;
				};
				var al_ = context.Operators.Where<Encounter>(aj_, ak_);
				object am_(Encounter @this)
				{
					var dd_ = @this?.Period;
					var de_ = FHIRHelpers_4_3_000.ToInterval(dd_);
					var df_ = context.Operators.End(de_);

					return df_;
				};
				var an_ = context.Operators.SortBy<Encounter>(al_, am_, System.ComponentModel.ListSortDirection.Ascending);
				var ao_ = context.Operators.Last<Encounter>(an_);
				var ap_ = ao_?.Period;
				var aq_ = FHIRHelpers_4_3_000.ToInterval(ap_);
				var ar_ = context.Operators.Start(aq_);
				var as_ = Visit?.Period;
				var at_ = FHIRHelpers_4_3_000.ToInterval(as_);
				var au_ = context.Operators.Start(at_);
				var av_ = context.Operators.Quantity(1m, "hour");
				var aw_ = context.Operators.Subtract((ar_ ?? au_), av_);
				var ay_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, null);
				bool? az_(Encounter LastObs)
				{
					var dg_ = LastObs?.Period;
					var dh_ = FHIRHelpers_4_3_000.ToInterval(dg_);
					var di_ = context.Operators.End(dh_);
					var dj_ = Visit?.Period;
					var dk_ = FHIRHelpers_4_3_000.ToInterval(dj_);
					var dl_ = context.Operators.Start(dk_);
					var dm_ = context.Operators.Quantity(1m, "hour");
					var dn_ = context.Operators.Subtract(dl_, dm_);
					var dp_ = FHIRHelpers_4_3_000.ToInterval(dj_);
					var dq_ = context.Operators.Start(dp_);
					var dr_ = context.Operators.Interval(dn_, dq_, true, true);
					var ds_ = context.Operators.In<CqlDateTime>(di_, dr_, null);
					var du_ = FHIRHelpers_4_3_000.ToInterval(dj_);
					var dv_ = context.Operators.Start(du_);
					var dw_ = context.Operators.Not((bool?)(dv_ is null));
					var dx_ = context.Operators.And(ds_, dw_);
					var dy_ = LastObs?.StatusElement;
					var dz_ = dy_?.Value;
					var ea_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dz_);
					var eb_ = context.Operators.Equal(ea_, "finished");
					var ec_ = context.Operators.And(dx_, eb_);

					return ec_;
				};
				var ba_ = context.Operators.Where<Encounter>(ay_, az_);
				object bb_(Encounter @this)
				{
					var ed_ = @this?.Period;
					var ee_ = FHIRHelpers_4_3_000.ToInterval(ed_);
					var ef_ = context.Operators.End(ee_);

					return ef_;
				};
				var bc_ = context.Operators.SortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
				var bd_ = context.Operators.Last<Encounter>(bc_);
				var be_ = bd_?.Period;
				var bf_ = FHIRHelpers_4_3_000.ToInterval(be_);
				var bg_ = context.Operators.Start(bf_);
				var bi_ = FHIRHelpers_4_3_000.ToInterval(as_);
				var bj_ = context.Operators.Start(bi_);
				var bk_ = context.Operators.Interval(aw_, (bg_ ?? bj_), true, true);
				var bl_ = context.Operators.In<CqlDateTime>(ah_, bk_, null);
				var bn_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, null);
				bool? bo_(Encounter LastObs)
				{
					var eg_ = LastObs?.Period;
					var eh_ = FHIRHelpers_4_3_000.ToInterval(eg_);
					var ei_ = context.Operators.End(eh_);
					var ej_ = Visit?.Period;
					var ek_ = FHIRHelpers_4_3_000.ToInterval(ej_);
					var el_ = context.Operators.Start(ek_);
					var em_ = context.Operators.Quantity(1m, "hour");
					var en_ = context.Operators.Subtract(el_, em_);
					var ep_ = FHIRHelpers_4_3_000.ToInterval(ej_);
					var eq_ = context.Operators.Start(ep_);
					var er_ = context.Operators.Interval(en_, eq_, true, true);
					var es_ = context.Operators.In<CqlDateTime>(ei_, er_, null);
					var eu_ = FHIRHelpers_4_3_000.ToInterval(ej_);
					var ev_ = context.Operators.Start(eu_);
					var ew_ = context.Operators.Not((bool?)(ev_ is null));
					var ex_ = context.Operators.And(es_, ew_);
					var ey_ = LastObs?.StatusElement;
					var ez_ = ey_?.Value;
					var fa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ez_);
					var fb_ = context.Operators.Equal(fa_, "finished");
					var fc_ = context.Operators.And(ex_, fb_);

					return fc_;
				};
				var bp_ = context.Operators.Where<Encounter>(bn_, bo_);
				object bq_(Encounter @this)
				{
					var fd_ = @this?.Period;
					var fe_ = FHIRHelpers_4_3_000.ToInterval(fd_);
					var ff_ = context.Operators.End(fe_);

					return ff_;
				};
				var br_ = context.Operators.SortBy<Encounter>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);
				var bs_ = context.Operators.Last<Encounter>(br_);
				var bt_ = bs_?.Period;
				var bu_ = FHIRHelpers_4_3_000.ToInterval(bt_);
				var bv_ = context.Operators.Start(bu_);
				var bx_ = FHIRHelpers_4_3_000.ToInterval(as_);
				var by_ = context.Operators.Start(bx_);
				var bz_ = context.Operators.Not((bool?)((bv_ ?? by_) is null));
				var ca_ = context.Operators.And(bl_, bz_);
				var cb_ = LastEDOBTriage?.StatusElement;
				var cc_ = cb_?.Value;
				var cd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cc_);
				var ce_ = context.Operators.Equal(cd_, "finished");
				var cf_ = context.Operators.And(ca_, ce_);

				return cf_;
			};
			var h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var fg_ = @this?.Period;
				var fh_ = FHIRHelpers_4_3_000.ToInterval(fg_);
				var fi_ = context.Operators.End(fh_);

				return fi_;
			};
			var j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.Last<Encounter>(j_);
			var l_ = k_?.Period;
			var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
			var n_ = context.Operators.Start(m_);
			var o_ = this.Observation_Services();
			var p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, null);
			bool? q_(Encounter LastObs)
			{
				var fj_ = LastObs?.Period;
				var fk_ = FHIRHelpers_4_3_000.ToInterval(fj_);
				var fl_ = context.Operators.End(fk_);
				var fm_ = Visit?.Period;
				var fn_ = FHIRHelpers_4_3_000.ToInterval(fm_);
				var fo_ = context.Operators.Start(fn_);
				var fp_ = context.Operators.Quantity(1m, "hour");
				var fq_ = context.Operators.Subtract(fo_, fp_);
				var fs_ = FHIRHelpers_4_3_000.ToInterval(fm_);
				var ft_ = context.Operators.Start(fs_);
				var fu_ = context.Operators.Interval(fq_, ft_, true, true);
				var fv_ = context.Operators.In<CqlDateTime>(fl_, fu_, null);
				var fx_ = FHIRHelpers_4_3_000.ToInterval(fm_);
				var fy_ = context.Operators.Start(fx_);
				var fz_ = context.Operators.Not((bool?)(fy_ is null));
				var ga_ = context.Operators.And(fv_, fz_);
				var gb_ = LastObs?.StatusElement;
				var gc_ = gb_?.Value;
				var gd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gc_);
				var ge_ = context.Operators.Equal(gd_, "finished");
				var gf_ = context.Operators.And(ga_, ge_);

				return gf_;
			};
			var r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				var gg_ = @this?.Period;
				var gh_ = FHIRHelpers_4_3_000.ToInterval(gg_);
				var gi_ = context.Operators.End(gh_);

				return gi_;
			};
			var t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.Last<Encounter>(t_);
			var v_ = u_?.Period;
			var w_ = FHIRHelpers_4_3_000.ToInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = Visit?.Period;
			var z_ = FHIRHelpers_4_3_000.ToInterval(y_);
			var aa_ = context.Operators.Start(z_);
			var ac_ = FHIRHelpers_4_3_000.ToInterval(y_);
			var ad_ = context.Operators.End(ac_);
			var ae_ = context.Operators.Interval((n_ ?? (x_ ?? aa_)), ad_, true, true);

			return ae_;
		};
		var c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

	private IEnumerable<Encounter> Delivery_Encounter_with_Age_Range_Value()
	{
		var a_ = this.Encounter_with_Age_Range();
		IEnumerable<Encounter> b_(Encounter EncounterWithAge)
		{
			var d_ = this.Delivery_Procedures();
			var e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
			bool? f_(Procedure DeliveryProcedure)
			{
				var j_ = DeliveryProcedure?.StatusElement;
				var k_ = j_?.Value;
				var l_ = context.Operators.Convert<string>(k_);
				var m_ = context.Operators.Equal(l_, "completed");
				var n_ = DeliveryProcedure?.Performed;
				var o_ = FHIRHelpers_4_3_000.ToValue(n_);
				var p_ = QICoreCommon_2_0_000.toInterval(o_);
				var q_ = context.Operators.Start(p_);
				var r_ = this.hospitalizationWithEDOBTriageObservation(EncounterWithAge);
				var s_ = context.Operators.In<CqlDateTime>(q_, r_, null);
				var t_ = context.Operators.And(m_, s_);

				return t_;
			};
			var g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure DeliveryProcedure) => 
				EncounterWithAge;
			var i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Age Range")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Age_Range() => 
		__Delivery_Encounter_with_Age_Range.Value;

    [CqlDeclaration("lastTimeOfDelivery")]
	public CqlDateTime lastTimeOfDelivery(Encounter TheEncounter)
	{
		var a_ = this.Date_and_time_of_obstetric_delivery();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation TimeOfDelivery)
		{
			var j_ = TimeOfDelivery?.Value;
			var k_ = FHIRHelpers_4_3_000.ToValue(j_);
			var l_ = context.Operators.Not((bool?)((k_ as CqlDateTime) is null));
			var m_ = TimeOfDelivery?.StatusElement;
			var n_ = m_?.Value;
			var o_ = context.Operators.Convert<Code<ObservationStatus>>(n_);
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var r_ = context.Operators.In<string>(p_, (q_ as IEnumerable<string>));
			var s_ = context.Operators.And(l_, r_);
			object t_()
			{
				bool ad_()
				{
					var ag_ = TimeOfDelivery?.Effective;
					var ah_ = FHIRHelpers_4_3_000.ToValue(ag_);
					var ai_ = ah_ is CqlDateTime;

					return ai_;
				};
				bool ae_()
				{
					var aj_ = TimeOfDelivery?.Effective;
					var ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
					var al_ = ak_ is CqlInterval<CqlDateTime>;

					return al_;
				};
				bool af_()
				{
					var am_ = TimeOfDelivery?.Effective;
					var an_ = FHIRHelpers_4_3_000.ToValue(am_);
					var ao_ = an_ is CqlDateTime;

					return ao_;
				};
				if (ad_())
				{
					var ap_ = TimeOfDelivery?.Effective;
					var aq_ = FHIRHelpers_4_3_000.ToValue(ap_);

					return ((aq_ as CqlDateTime) as object);
				}
				else if (ae_())
				{
					var ar_ = TimeOfDelivery?.Effective;
					var as_ = FHIRHelpers_4_3_000.ToValue(ar_);

					return ((as_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (af_())
				{
					var at_ = TimeOfDelivery?.Effective;
					var au_ = FHIRHelpers_4_3_000.ToValue(at_);

					return ((au_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var u_ = QICoreCommon_2_0_000.earliest(t_());
			var v_ = this.hospitalizationWithEDOBTriageObservation(TheEncounter);
			var w_ = context.Operators.In<CqlDateTime>(u_, v_, null);
			var x_ = context.Operators.And(s_, w_);
			var z_ = FHIRHelpers_4_3_000.ToValue(j_);
			var ab_ = context.Operators.In<CqlDateTime>((z_ as CqlDateTime), v_, null);
			var ac_ = context.Operators.And(x_, ab_);

			return ac_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object av_()
			{
				bool ax_()
				{
					var ba_ = @this?.Effective;
					var bb_ = FHIRHelpers_4_3_000.ToValue(ba_);
					var bc_ = bb_ is CqlDateTime;

					return bc_;
				};
				bool ay_()
				{
					var bd_ = @this?.Effective;
					var be_ = FHIRHelpers_4_3_000.ToValue(bd_);
					var bf_ = be_ is CqlInterval<CqlDateTime>;

					return bf_;
				};
				bool az_()
				{
					var bg_ = @this?.Effective;
					var bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
					var bi_ = bh_ is CqlDateTime;

					return bi_;
				};
				if (ax_())
				{
					var bj_ = @this?.Effective;
					var bk_ = FHIRHelpers_4_3_000.ToValue(bj_);

					return ((bk_ as CqlDateTime) as object);
				}
				else if (ay_())
				{
					var bl_ = @this?.Effective;
					var bm_ = FHIRHelpers_4_3_000.ToValue(bl_);

					return ((bm_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (az_())
				{
					var bn_ = @this?.Effective;
					var bo_ = FHIRHelpers_4_3_000.ToValue(bn_);

					return ((bo_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var aw_ = QICoreCommon_2_0_000.earliest(av_());

			return aw_;
		};
		var g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.Last<Observation>(g_);
		var i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (i_ as CqlDateTime);
	}

    [CqlDeclaration("lastEstimatedDeliveryDate")]
	public CqlDateTime lastEstimatedDeliveryDate(Encounter TheEncounter)
	{
		var a_ = this.Delivery_date_Estimated();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation EstimatedDateOfDelivery)
		{
			var j_ = EstimatedDateOfDelivery?.Value;
			var k_ = FHIRHelpers_4_3_000.ToValue(j_);
			var l_ = context.Operators.Not((bool?)((k_ as CqlDateTime) is null));
			var m_ = EstimatedDateOfDelivery?.StatusElement;
			var n_ = m_?.Value;
			var o_ = context.Operators.Convert<Code<ObservationStatus>>(n_);
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var r_ = context.Operators.In<string>(p_, (q_ as IEnumerable<string>));
			var s_ = context.Operators.And(l_, r_);
			object t_()
			{
				bool af_()
				{
					var ai_ = EstimatedDateOfDelivery?.Effective;
					var aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
					var ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				bool ag_()
				{
					var al_ = EstimatedDateOfDelivery?.Effective;
					var am_ = FHIRHelpers_4_3_000.ToValue(al_);
					var an_ = am_ is CqlInterval<CqlDateTime>;

					return an_;
				};
				bool ah_()
				{
					var ao_ = EstimatedDateOfDelivery?.Effective;
					var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
					var aq_ = ap_ is CqlDateTime;

					return aq_;
				};
				if (af_())
				{
					var ar_ = EstimatedDateOfDelivery?.Effective;
					var as_ = FHIRHelpers_4_3_000.ToValue(ar_);

					return ((as_ as CqlDateTime) as object);
				}
				else if (ag_())
				{
					var at_ = EstimatedDateOfDelivery?.Effective;
					var au_ = FHIRHelpers_4_3_000.ToValue(at_);

					return ((au_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ah_())
				{
					var av_ = EstimatedDateOfDelivery?.Effective;
					var aw_ = FHIRHelpers_4_3_000.ToValue(av_);

					return ((aw_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var u_ = QICoreCommon_2_0_000.earliest(t_());
			var v_ = this.lastTimeOfDelivery(TheEncounter);
			var w_ = context.Operators.Quantity(42m, "weeks");
			var x_ = context.Operators.Subtract(v_, w_);
			var z_ = context.Operators.Interval(x_, v_, true, true);
			var aa_ = context.Operators.In<CqlDateTime>(u_, z_, null);
			var ac_ = context.Operators.Not((bool?)(v_ is null));
			var ad_ = context.Operators.And(aa_, ac_);
			var ae_ = context.Operators.And(s_, ad_);

			return ae_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ax_()
			{
				bool az_()
				{
					var bc_ = @this?.Effective;
					var bd_ = FHIRHelpers_4_3_000.ToValue(bc_);
					var be_ = bd_ is CqlDateTime;

					return be_;
				};
				bool ba_()
				{
					var bf_ = @this?.Effective;
					var bg_ = FHIRHelpers_4_3_000.ToValue(bf_);
					var bh_ = bg_ is CqlInterval<CqlDateTime>;

					return bh_;
				};
				bool bb_()
				{
					var bi_ = @this?.Effective;
					var bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
					var bk_ = bj_ is CqlDateTime;

					return bk_;
				};
				if (az_())
				{
					var bl_ = @this?.Effective;
					var bm_ = FHIRHelpers_4_3_000.ToValue(bl_);

					return ((bm_ as CqlDateTime) as object);
				}
				else if (ba_())
				{
					var bn_ = @this?.Effective;
					var bo_ = FHIRHelpers_4_3_000.ToValue(bn_);

					return ((bo_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bb_())
				{
					var bp_ = @this?.Effective;
					var bq_ = FHIRHelpers_4_3_000.ToValue(bp_);

					return ((bq_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var ay_ = QICoreCommon_2_0_000.earliest(ax_());

			return ay_;
		};
		var g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.Last<Observation>(g_);
		var i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (i_ as CqlDateTime);
	}

    [CqlDeclaration("calculatedGestationalAge")]
	public int? calculatedGestationalAge(Encounter TheEncounter)
	{
		var a_ = this.lastTimeOfDelivery(TheEncounter);
		var b_ = this.lastEstimatedDeliveryDate(TheEncounter);
		var c_ = context.Operators.DifferenceBetween(a_, b_, "day");
		var d_ = context.Operators.Subtract(280, c_);
		var e_ = context.Operators.TruncatedDivide(d_, 7);

		return e_;
	}

	private IEnumerable<Tuple_QRZgNJCaGQEYIeOSBhjLZNSO> Variable_Calculated_Gestational_Age_Value()
	{
		var a_ = this.Delivery_Encounter_with_Age_Range();
		Tuple_QRZgNJCaGQEYIeOSBhjLZNSO b_(Encounter DeliveryEncounter)
		{
			var d_ = DeliveryEncounter?.IdElement;
			var e_ = d_?.Value;
			var f_ = this.calculatedGestationalAge(DeliveryEncounter);
			var g_ = new Tuple_QRZgNJCaGQEYIeOSBhjLZNSO
			{
				EncounterID = e_,
				CalculatedCGA = f_,
			};

			return g_;
		};
		var c_ = context.Operators.Select<Encounter, Tuple_QRZgNJCaGQEYIeOSBhjLZNSO>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Variable Calculated Gestational Age")]
	public IEnumerable<Tuple_QRZgNJCaGQEYIeOSBhjLZNSO> Variable_Calculated_Gestational_Age() => 
		__Variable_Calculated_Gestational_Age.Value;

    [CqlDeclaration("lastEstimatedGestationalAge")]
	public CqlQuantity lastEstimatedGestationalAge(Encounter TheEncounter)
	{
		var a_ = this.Estimated_Gestational_Age_at_Delivery();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation EstimatedGestationalAge)
		{
			object i_()
			{
				bool as_()
				{
					var av_ = EstimatedGestationalAge?.Effective;
					var aw_ = FHIRHelpers_4_3_000.ToValue(av_);
					var ax_ = aw_ is CqlDateTime;

					return ax_;
				};
				bool at_()
				{
					var ay_ = EstimatedGestationalAge?.Effective;
					var az_ = FHIRHelpers_4_3_000.ToValue(ay_);
					var ba_ = az_ is CqlInterval<CqlDateTime>;

					return ba_;
				};
				bool au_()
				{
					var bb_ = EstimatedGestationalAge?.Effective;
					var bc_ = FHIRHelpers_4_3_000.ToValue(bb_);
					var bd_ = bc_ is CqlDateTime;

					return bd_;
				};
				if (as_())
				{
					var be_ = EstimatedGestationalAge?.Effective;
					var bf_ = FHIRHelpers_4_3_000.ToValue(be_);

					return ((bf_ as CqlDateTime) as object);
				}
				else if (at_())
				{
					var bg_ = EstimatedGestationalAge?.Effective;
					var bh_ = FHIRHelpers_4_3_000.ToValue(bg_);

					return ((bh_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (au_())
				{
					var bi_ = EstimatedGestationalAge?.Effective;
					var bj_ = FHIRHelpers_4_3_000.ToValue(bi_);

					return ((bj_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var j_ = QICoreCommon_2_0_000.earliest(i_());
			var k_ = this.lastTimeOfDelivery(TheEncounter);
			var l_ = context.Operators.Quantity(24m, "hours");
			var m_ = context.Operators.Subtract(k_, l_);
			var o_ = context.Operators.Interval(m_, k_, true, true);
			var p_ = context.Operators.In<CqlDateTime>(j_, o_, null);
			var r_ = context.Operators.Not((bool?)(k_ is null));
			var s_ = context.Operators.And(p_, r_);
			var t_ = EstimatedGestationalAge?.Value;
			var u_ = FHIRHelpers_4_3_000.ToValue(t_);
			var v_ = context.Operators.Not((bool?)(u_ is null));
			var w_ = context.Operators.And(s_, v_);
			var x_ = EstimatedGestationalAge?.StatusElement;
			var y_ = x_?.Value;
			var z_ = context.Operators.Convert<Code<ObservationStatus>>(y_);
			var aa_ = context.Operators.Convert<string>(z_);
			var ab_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var ac_ = context.Operators.In<string>(aa_, (ab_ as IEnumerable<string>));
			var ad_ = context.Operators.And(w_, ac_);
			object ae_()
			{
				bool bk_()
				{
					var bn_ = EstimatedGestationalAge?.Effective;
					var bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
					var bp_ = bo_ is CqlDateTime;

					return bp_;
				};
				bool bl_()
				{
					var bq_ = EstimatedGestationalAge?.Effective;
					var br_ = FHIRHelpers_4_3_000.ToValue(bq_);
					var bs_ = br_ is CqlInterval<CqlDateTime>;

					return bs_;
				};
				bool bm_()
				{
					var bt_ = EstimatedGestationalAge?.Effective;
					var bu_ = FHIRHelpers_4_3_000.ToValue(bt_);
					var bv_ = bu_ is CqlDateTime;

					return bv_;
				};
				if (bk_())
				{
					var bw_ = EstimatedGestationalAge?.Effective;
					var bx_ = FHIRHelpers_4_3_000.ToValue(bw_);

					return ((bx_ as CqlDateTime) as object);
				}
				else if (bl_())
				{
					var by_ = EstimatedGestationalAge?.Effective;
					var bz_ = FHIRHelpers_4_3_000.ToValue(by_);

					return ((bz_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bm_())
				{
					var ca_ = EstimatedGestationalAge?.Effective;
					var cb_ = FHIRHelpers_4_3_000.ToValue(ca_);

					return ((cb_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var af_ = QICoreCommon_2_0_000.earliest(ae_());
			var ah_ = context.Operators.SameAs(af_, k_, "day");
			object ai_()
			{
				bool cc_()
				{
					var cf_ = EstimatedGestationalAge?.Effective;
					var cg_ = FHIRHelpers_4_3_000.ToValue(cf_);
					var ch_ = cg_ is CqlDateTime;

					return ch_;
				};
				bool cd_()
				{
					var ci_ = EstimatedGestationalAge?.Effective;
					var cj_ = FHIRHelpers_4_3_000.ToValue(ci_);
					var ck_ = cj_ is CqlInterval<CqlDateTime>;

					return ck_;
				};
				bool ce_()
				{
					var cl_ = EstimatedGestationalAge?.Effective;
					var cm_ = FHIRHelpers_4_3_000.ToValue(cl_);
					var cn_ = cm_ is CqlDateTime;

					return cn_;
				};
				if (cc_())
				{
					var co_ = EstimatedGestationalAge?.Effective;
					var cp_ = FHIRHelpers_4_3_000.ToValue(co_);

					return ((cp_ as CqlDateTime) as object);
				}
				else if (cd_())
				{
					var cq_ = EstimatedGestationalAge?.Effective;
					var cr_ = FHIRHelpers_4_3_000.ToValue(cq_);

					return ((cr_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ce_())
				{
					var cs_ = EstimatedGestationalAge?.Effective;
					var ct_ = FHIRHelpers_4_3_000.ToValue(cs_);

					return ((ct_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var aj_ = QICoreCommon_2_0_000.earliest(ai_());
			var ak_ = this.hospitalizationWithEDOBTriageObservation(TheEncounter);
			var al_ = context.Operators.In<CqlDateTime>(aj_, ak_, null);
			var am_ = context.Operators.And(ah_, al_);
			var ao_ = FHIRHelpers_4_3_000.ToValue(t_);
			var ap_ = context.Operators.Not((bool?)(ao_ is null));
			var aq_ = context.Operators.And(am_, ap_);
			var ar_ = context.Operators.Or(ad_, aq_);

			return ar_;
		};
		var d_ = context.Operators.Where<Observation>(b_, c_);
		object e_(Observation @this)
		{
			object cu_()
			{
				bool cw_()
				{
					var cz_ = @this?.Effective;
					var da_ = FHIRHelpers_4_3_000.ToValue(cz_);
					var db_ = da_ is CqlDateTime;

					return db_;
				};
				bool cx_()
				{
					var dc_ = @this?.Effective;
					var dd_ = FHIRHelpers_4_3_000.ToValue(dc_);
					var de_ = dd_ is CqlInterval<CqlDateTime>;

					return de_;
				};
				bool cy_()
				{
					var df_ = @this?.Effective;
					var dg_ = FHIRHelpers_4_3_000.ToValue(df_);
					var dh_ = dg_ is CqlDateTime;

					return dh_;
				};
				if (cw_())
				{
					var di_ = @this?.Effective;
					var dj_ = FHIRHelpers_4_3_000.ToValue(di_);

					return ((dj_ as CqlDateTime) as object);
				}
				else if (cx_())
				{
					var dk_ = @this?.Effective;
					var dl_ = FHIRHelpers_4_3_000.ToValue(dk_);

					return ((dl_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (cy_())
				{
					var dm_ = @this?.Effective;
					var dn_ = FHIRHelpers_4_3_000.ToValue(dm_);

					return ((dn_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var cv_ = QICoreCommon_2_0_000.earliest(cu_());

			return cv_;
		};
		var f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.Last<Observation>(f_);
		var h_ = FHIRHelpers_4_3_000.ToValue(g_?.Value);

		return (h_ as CqlQuantity);
	}

}
