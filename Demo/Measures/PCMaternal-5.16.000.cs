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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
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
    internal Lazy<IEnumerable<Tuples.Tuple_CDQdAjUGdePbWTVfePeZUXKFM>> __Variable_Calculated_Gestational_Age;

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
        __Variable_Calculated_Gestational_Age = new Lazy<IEnumerable<Tuples.Tuple_CDQdAjUGdePbWTVfePeZUXKFM>>(this.Variable_Calculated_Gestational_Age_Value);
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
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("PCMaternal-5.16.000", "Measurement Period", e_);

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

	private IEnumerable<Encounter> Encounter_with_Age_Range_Value()
	{
		var a_ = CQMCommon_2_0_000.Inpatient_Encounter();
		bool? b_(Encounter InpatientEncounter)
		{
			var d_ = this.Patient();
			var e_ = context.Operators.Convert<CqlDate>(d_?.BirthDateElement?.Value);
			var f_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
			var g_ = context.Operators.Start(f_);
			var h_ = context.Operators.DateFrom(g_);
			var i_ = context.Operators.CalculateAgeAt(e_, h_, "year");
			var j_ = context.Operators.Interval((int?)8, (int?)65, true, false);
			var k_ = context.Operators.ElementInInterval<int?>(i_, j_, null);

			return k_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

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
				var ab_ = FHIRHelpers_4_3_000.ToInterval(LastEDOBTriage?.Period);
				var ac_ = context.Operators.End(ab_);
				var ad_ = this.Observation_Services();
				var ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? af_(Encounter LastObs)
				{
					var bt_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var bu_ = context.Operators.End(bt_);
					var bv_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var bw_ = context.Operators.Start(bv_);
					var bx_ = context.Operators.Quantity(1m, "hour");
					var by_ = context.Operators.Subtract(bw_, bx_);
					var ca_ = context.Operators.Start(bv_);
					var cb_ = context.Operators.Interval(by_, ca_, true, true);
					var cc_ = context.Operators.ElementInInterval<CqlDateTime>(bu_, cb_, null);
					var ce_ = context.Operators.Start(bv_);
					var cf_ = context.Operators.Not((bool?)(ce_ is null));
					var cg_ = context.Operators.And(cc_, cf_);
					var ch_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var ci_ = context.Operators.Equal(ch_, "finished");
					var cj_ = context.Operators.And(cg_, ci_);

					return cj_;
				};
				var ag_ = context.Operators.WhereOrNull<Encounter>(ae_, af_);
				object ah_(Encounter @this)
				{
					var ck_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var cl_ = context.Operators.End(ck_);

					return cl_;
				};
				var ai_ = context.Operators.ListSortBy<Encounter>(ag_, ah_, System.ComponentModel.ListSortDirection.Ascending);
				var aj_ = context.Operators.LastOfList<Encounter>(ai_);
				var ak_ = FHIRHelpers_4_3_000.ToInterval(aj_?.Period);
				var al_ = context.Operators.Start(ak_);
				var am_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				var an_ = context.Operators.Start(am_);
				var ao_ = context.Operators.Quantity(1m, "hour");
				var ap_ = context.Operators.Subtract((al_ ?? an_), ao_);
				var ar_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? as_(Encounter LastObs)
				{
					var cm_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var cn_ = context.Operators.End(cm_);
					var co_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var cp_ = context.Operators.Start(co_);
					var cq_ = context.Operators.Quantity(1m, "hour");
					var cr_ = context.Operators.Subtract(cp_, cq_);
					var ct_ = context.Operators.Start(co_);
					var cu_ = context.Operators.Interval(cr_, ct_, true, true);
					var cv_ = context.Operators.ElementInInterval<CqlDateTime>(cn_, cu_, null);
					var cx_ = context.Operators.Start(co_);
					var cy_ = context.Operators.Not((bool?)(cx_ is null));
					var cz_ = context.Operators.And(cv_, cy_);
					var da_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var db_ = context.Operators.Equal(da_, "finished");
					var dc_ = context.Operators.And(cz_, db_);

					return dc_;
				};
				var at_ = context.Operators.WhereOrNull<Encounter>(ar_, as_);
				object au_(Encounter @this)
				{
					var dd_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var de_ = context.Operators.End(dd_);

					return de_;
				};
				var av_ = context.Operators.ListSortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
				var aw_ = context.Operators.LastOfList<Encounter>(av_);
				var ax_ = FHIRHelpers_4_3_000.ToInterval(aw_?.Period);
				var ay_ = context.Operators.Start(ax_);
				var ba_ = context.Operators.Start(am_);
				var bb_ = context.Operators.Interval(ap_, (ay_ ?? ba_), true, true);
				var bc_ = context.Operators.ElementInInterval<CqlDateTime>(ac_, bb_, null);
				var be_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? bf_(Encounter LastObs)
				{
					var df_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var dg_ = context.Operators.End(df_);
					var dh_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var di_ = context.Operators.Start(dh_);
					var dj_ = context.Operators.Quantity(1m, "hour");
					var dk_ = context.Operators.Subtract(di_, dj_);
					var dm_ = context.Operators.Start(dh_);
					var dn_ = context.Operators.Interval(dk_, dm_, true, true);
					var do_ = context.Operators.ElementInInterval<CqlDateTime>(dg_, dn_, null);
					var dq_ = context.Operators.Start(dh_);
					var dr_ = context.Operators.Not((bool?)(dq_ is null));
					var ds_ = context.Operators.And(do_, dr_);
					var dt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var du_ = context.Operators.Equal(dt_, "finished");
					var dv_ = context.Operators.And(ds_, du_);

					return dv_;
				};
				var bg_ = context.Operators.WhereOrNull<Encounter>(be_, bf_);
				object bh_(Encounter @this)
				{
					var dw_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var dx_ = context.Operators.End(dw_);

					return dx_;
				};
				var bi_ = context.Operators.ListSortBy<Encounter>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
				var bj_ = context.Operators.LastOfList<Encounter>(bi_);
				var bk_ = FHIRHelpers_4_3_000.ToInterval(bj_?.Period);
				var bl_ = context.Operators.Start(bk_);
				var bn_ = context.Operators.Start(am_);
				var bo_ = context.Operators.Not((bool?)((bl_ ?? bn_) is null));
				var bp_ = context.Operators.And(bc_, bo_);
				var bq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastEDOBTriage?.StatusElement?.Value);
				var br_ = context.Operators.Equal(bq_, "finished");
				var bs_ = context.Operators.And(bp_, br_);

				return bs_;
			};
			var h_ = context.Operators.WhereOrNull<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var dy_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				var dz_ = context.Operators.End(dy_);

				return dz_;
			};
			var j_ = context.Operators.ListSortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.LastOfList<Encounter>(j_);
			var l_ = FHIRHelpers_4_3_000.ToInterval(k_?.Period);
			var m_ = context.Operators.Start(l_);
			var n_ = this.Observation_Services();
			var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastObs)
			{
				var ea_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
				var eb_ = context.Operators.End(ea_);
				var ec_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				var ed_ = context.Operators.Start(ec_);
				var ee_ = context.Operators.Quantity(1m, "hour");
				var ef_ = context.Operators.Subtract(ed_, ee_);
				var eh_ = context.Operators.Start(ec_);
				var ei_ = context.Operators.Interval(ef_, eh_, true, true);
				var ej_ = context.Operators.ElementInInterval<CqlDateTime>(eb_, ei_, null);
				var el_ = context.Operators.Start(ec_);
				var em_ = context.Operators.Not((bool?)(el_ is null));
				var en_ = context.Operators.And(ej_, em_);
				var eo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
				var ep_ = context.Operators.Equal(eo_, "finished");
				var eq_ = context.Operators.And(en_, ep_);

				return eq_;
			};
			var q_ = context.Operators.WhereOrNull<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				var er_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				var es_ = context.Operators.End(er_);

				return es_;
			};
			var s_ = context.Operators.ListSortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context.Operators.LastOfList<Encounter>(s_);
			var u_ = FHIRHelpers_4_3_000.ToInterval(t_?.Period);
			var v_ = context.Operators.Start(u_);
			var w_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
			var x_ = context.Operators.Start(w_);
			var z_ = context.Operators.End(w_);
			var aa_ = context.Operators.Interval((m_ ?? (v_ ?? x_)), z_, true, true);

			return aa_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

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
				var j_ = context.Operators.EnumEqualsString(DeliveryProcedure?.StatusElement?.Value, "completed");
				var k_ = FHIRHelpers_4_3_000.ToValue(DeliveryProcedure?.Performed);
				var l_ = QICoreCommon_2_0_000.toInterval(k_);
				var m_ = context.Operators.Start(l_);
				var n_ = this.hospitalizationWithEDOBTriageObservation(EncounterWithAge);
				var o_ = context.Operators.ElementInInterval<CqlDateTime>(m_, n_, null);
				var p_ = context.Operators.And(j_, o_);

				return p_;
			};
			var g_ = context.Operators.WhereOrNull<Procedure>(e_, f_);
			Encounter h_(Procedure DeliveryProcedure) => 
				EncounterWithAge;
			var i_ = context.Operators.SelectOrNull<Procedure, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

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
			var j_ = FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Value);
			var k_ = context.Operators.Not((bool?)((j_ as CqlDateTime) is null));
			var l_ = context.Operators.Convert<Code<ObservationStatus>>(TimeOfDelivery?.StatusElement?.Value);
			var m_ = context.Operators.Convert<string>(l_);
			var n_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var o_ = context.Operators.InList<string>(m_, (n_ as IEnumerable<string>));
			var p_ = context.Operators.And(k_, o_);
			object q_()
			{
				if (FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Effective) is CqlDateTime)
				{
					var z_ = FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Effective);

					return ((z_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Effective) is CqlInterval<CqlDateTime>)
				{
					var aa_ = FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Effective);

					return ((aa_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Effective) is CqlDateTime)
				{
					var ab_ = FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Effective);

					return ((ab_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var r_ = QICoreCommon_2_0_000.earliest(q_());
			var s_ = this.hospitalizationWithEDOBTriageObservation(TheEncounter);
			var t_ = context.Operators.ElementInInterval<CqlDateTime>(r_, s_, null);
			var u_ = context.Operators.And(p_, t_);
			var x_ = context.Operators.ElementInInterval<CqlDateTime>((j_ as CqlDateTime), s_, null);
			var y_ = context.Operators.And(u_, x_);

			return y_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ac_()
			{
				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var ae_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ae_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					var af_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((af_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var ag_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ag_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ad_ = QICoreCommon_2_0_000.earliest(ac_());

			return ad_;
		};
		var g_ = context.Operators.ListSortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.LastOfList<Observation>(g_);
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
			var j_ = FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Value);
			var k_ = context.Operators.Not((bool?)((j_ as CqlDateTime) is null));
			var l_ = context.Operators.Convert<Code<ObservationStatus>>(EstimatedDateOfDelivery?.StatusElement?.Value);
			var m_ = context.Operators.Convert<string>(l_);
			var n_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var o_ = context.Operators.InList<string>(m_, (n_ as IEnumerable<string>));
			var p_ = context.Operators.And(k_, o_);
			object q_()
			{
				if (FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Effective) is CqlDateTime)
				{
					var ac_ = FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Effective);

					return ((ac_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ad_ = FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Effective);

					return ((ad_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Effective) is CqlDateTime)
				{
					var ae_ = FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Effective);

					return ((ae_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var r_ = QICoreCommon_2_0_000.earliest(q_());
			var s_ = this.lastTimeOfDelivery(TheEncounter);
			var t_ = context.Operators.Quantity(42m, "weeks");
			var u_ = context.Operators.Subtract(s_, t_);
			var w_ = context.Operators.Interval(u_, s_, true, true);
			var x_ = context.Operators.ElementInInterval<CqlDateTime>(r_, w_, null);
			var z_ = context.Operators.Not((bool?)(s_ is null));
			var aa_ = context.Operators.And(x_, z_);
			var ab_ = context.Operators.And(p_, aa_);

			return ab_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object af_()
			{
				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var ah_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ah_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ai_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ai_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var aj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((aj_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ag_ = QICoreCommon_2_0_000.earliest(af_());

			return ag_;
		};
		var g_ = context.Operators.ListSortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.LastOfList<Observation>(g_);
		var i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (i_ as CqlDateTime);
	}

    [CqlDeclaration("calculatedGestationalAge")]
	public int? calculatedGestationalAge(Encounter TheEncounter)
	{
		var a_ = this.lastTimeOfDelivery(TheEncounter);
		var b_ = this.lastEstimatedDeliveryDate(TheEncounter);
		var c_ = context.Operators.DifferenceBetween(a_, b_, "day");
		var d_ = context.Operators.Subtract((int?)280, c_);
		var e_ = context.Operators.TruncateDivide(d_, (int?)7);

		return e_;
	}

	private IEnumerable<Tuples.Tuple_CDQdAjUGdePbWTVfePeZUXKFM> Variable_Calculated_Gestational_Age_Value()
	{
		var a_ = this.Delivery_Encounter_with_Age_Range();
		Tuples.Tuple_CDQdAjUGdePbWTVfePeZUXKFM b_(Encounter DeliveryEncounter)
		{
			var d_ = this.calculatedGestationalAge(DeliveryEncounter);
			var e_ = new Tuples.Tuple_CDQdAjUGdePbWTVfePeZUXKFM
			{
				EncounterID = DeliveryEncounter?.IdElement?.Value,
				CalculatedCGA = d_,
			};

			return e_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_CDQdAjUGdePbWTVfePeZUXKFM>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Variable Calculated Gestational Age")]
	public IEnumerable<Tuples.Tuple_CDQdAjUGdePbWTVfePeZUXKFM> Variable_Calculated_Gestational_Age() => 
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
				if (FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective) is CqlDateTime)
				{
					var ao_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((ao_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ap_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((ap_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective) is CqlDateTime)
				{
					var aq_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((aq_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var j_ = QICoreCommon_2_0_000.earliest(i_());
			var k_ = this.lastTimeOfDelivery(TheEncounter);
			var l_ = context.Operators.Quantity(24m, "hours");
			var m_ = context.Operators.Subtract(k_, l_);
			var o_ = context.Operators.Interval(m_, k_, true, true);
			var p_ = context.Operators.ElementInInterval<CqlDateTime>(j_, o_, null);
			var r_ = context.Operators.Not((bool?)(k_ is null));
			var s_ = context.Operators.And(p_, r_);
			var t_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Value);
			var u_ = context.Operators.Not((bool?)(t_ is null));
			var v_ = context.Operators.And(s_, u_);
			var w_ = context.Operators.Convert<Code<ObservationStatus>>(EstimatedGestationalAge?.StatusElement?.Value);
			var x_ = context.Operators.Convert<string>(w_);
			var y_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var z_ = context.Operators.InList<string>(x_, (y_ as IEnumerable<string>));
			var aa_ = context.Operators.And(v_, z_);
			object ab_()
			{
				if (FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective) is CqlDateTime)
				{
					var ar_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((ar_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective) is CqlInterval<CqlDateTime>)
				{
					var as_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((as_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective) is CqlDateTime)
				{
					var at_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((at_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ac_ = QICoreCommon_2_0_000.earliest(ab_());
			var ae_ = context.Operators.SameAs(ac_, k_, "day");
			object af_()
			{
				if (FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective) is CqlDateTime)
				{
					var au_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((au_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective) is CqlInterval<CqlDateTime>)
				{
					var av_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((av_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective) is CqlDateTime)
				{
					var aw_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((aw_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ag_ = QICoreCommon_2_0_000.earliest(af_());
			var ah_ = this.hospitalizationWithEDOBTriageObservation(TheEncounter);
			var ai_ = context.Operators.ElementInInterval<CqlDateTime>(ag_, ah_, null);
			var aj_ = context.Operators.And(ae_, ai_);
			var al_ = context.Operators.Not((bool?)(t_ is null));
			var am_ = context.Operators.And(aj_, al_);
			var an_ = context.Operators.Or(aa_, am_);

			return an_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		object e_(Observation @this)
		{
			object ax_()
			{
				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var az_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((az_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ba_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ba_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var bb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((bb_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ay_ = QICoreCommon_2_0_000.earliest(ax_());

			return ay_;
		};
		var f_ = context.Operators.ListSortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.LastOfList<Observation>(f_);
		var h_ = FHIRHelpers_4_3_000.ToValue(g_?.Value);

		return (h_ as CqlQuantity);
	}

}