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
    internal Lazy<IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM>> __Variable_Calculated_Gestational_Age;

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
        __Variable_Calculated_Gestational_Age = new Lazy<IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM>>(this.Variable_Calculated_Gestational_Age_Value);
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
		CqlCode[] a_ = new CqlCode[]
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
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("PCMaternal-5.16.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Encounter_with_Age_Range_Value()
	{
		IEnumerable<Encounter> a_ = CQMCommon_2_0_000.Inpatient_Encounter();
		bool? b_(Encounter InpatientEncounter)
		{
			Patient d_ = this.Patient();
			CqlDate e_ = context.Operators.Convert<CqlDate>(d_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlDate h_ = context.Operators.DateFrom(g_);
			int? i_ = context.Operators.CalculateAgeAt(e_, h_, "year");
			CqlInterval<int?> j_ = context.Operators.Interval(8, 65, true, false);
			bool? k_ = context.Operators.In<int?>(i_, j_, null);

			return k_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Age Range")]
	public IEnumerable<Encounter> Encounter_with_Age_Range() => 
		__Encounter_with_Age_Range.Value;

    [CqlDeclaration("hospitalizationWithEDOBTriageObservation")]
	public CqlInterval<CqlDateTime> hospitalizationWithEDOBTriageObservation(Encounter TheEncounter)
	{
		Encounter[] a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.ED_Visit_and_OB_Triage();
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastEDOBTriage)
			{
				CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_3_000.ToInterval(LastEDOBTriage?.Period);
				CqlDateTime ac_ = context.Operators.End(ab_);
				CqlValueSet ad_ = this.Observation_Services();
				IEnumerable<Encounter> ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? af_(Encounter LastObs)
				{
					CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime bu_ = context.Operators.End(bt_);
					CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime bw_ = context.Operators.Start(bv_);
					CqlQuantity bx_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime by_ = context.Operators.Subtract(bw_, bx_);
					CqlDateTime ca_ = context.Operators.Start(bv_);
					CqlInterval<CqlDateTime> cb_ = context.Operators.Interval(by_, ca_, true, true);
					bool? cc_ = context.Operators.In<CqlDateTime>(bu_, cb_, null);
					CqlDateTime ce_ = context.Operators.Start(bv_);
					bool? cf_ = context.Operators.Not((bool?)(ce_ is null));
					bool? cg_ = context.Operators.And(cc_, cf_);
					Code<Encounter.EncounterStatus> ch_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? ci_ = context.Operators.Equal(ch_, "finished");
					bool? cj_ = context.Operators.And(cg_, ci_);

					return cj_;
				};
				IEnumerable<Encounter> ag_ = context.Operators.Where<Encounter>(ae_, af_);
				object ah_(Encounter @this)
				{
					CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime cl_ = context.Operators.End(ck_);

					return cl_;
				};
				IEnumerable<Encounter> ai_ = context.Operators.SortBy<Encounter>(ag_, ah_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter aj_ = context.Operators.Last<Encounter>(ai_);
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(aj_?.Period);
				CqlDateTime al_ = context.Operators.Start(ak_);
				CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				CqlDateTime an_ = context.Operators.Start(am_);
				CqlQuantity ao_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ap_ = context.Operators.Subtract((al_ ?? an_), ao_);
				IEnumerable<Encounter> ar_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? as_(Encounter LastObs)
				{
					CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime cn_ = context.Operators.End(cm_);
					CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime cp_ = context.Operators.Start(co_);
					CqlQuantity cq_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime cr_ = context.Operators.Subtract(cp_, cq_);
					CqlDateTime ct_ = context.Operators.Start(co_);
					CqlInterval<CqlDateTime> cu_ = context.Operators.Interval(cr_, ct_, true, true);
					bool? cv_ = context.Operators.In<CqlDateTime>(cn_, cu_, null);
					CqlDateTime cx_ = context.Operators.Start(co_);
					bool? cy_ = context.Operators.Not((bool?)(cx_ is null));
					bool? cz_ = context.Operators.And(cv_, cy_);
					Code<Encounter.EncounterStatus> da_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? db_ = context.Operators.Equal(da_, "finished");
					bool? dc_ = context.Operators.And(cz_, db_);

					return dc_;
				};
				IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);
				object au_(Encounter @this)
				{
					CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime de_ = context.Operators.End(dd_);

					return de_;
				};
				IEnumerable<Encounter> av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter aw_ = context.Operators.Last<Encounter>(av_);
				CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_3_000.ToInterval(aw_?.Period);
				CqlDateTime ay_ = context.Operators.Start(ax_);
				CqlDateTime ba_ = context.Operators.Start(am_);
				CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(ap_, (ay_ ?? ba_), true, true);
				bool? bc_ = context.Operators.In<CqlDateTime>(ac_, bb_, null);
				IEnumerable<Encounter> be_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? bf_(Encounter LastObs)
				{
					CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime dg_ = context.Operators.End(df_);
					CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime di_ = context.Operators.Start(dh_);
					CqlQuantity dj_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dk_ = context.Operators.Subtract(di_, dj_);
					CqlDateTime dm_ = context.Operators.Start(dh_);
					CqlInterval<CqlDateTime> dn_ = context.Operators.Interval(dk_, dm_, true, true);
					bool? do_ = context.Operators.In<CqlDateTime>(dg_, dn_, null);
					CqlDateTime dq_ = context.Operators.Start(dh_);
					bool? dr_ = context.Operators.Not((bool?)(dq_ is null));
					bool? ds_ = context.Operators.And(do_, dr_);
					Code<Encounter.EncounterStatus> dt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? du_ = context.Operators.Equal(dt_, "finished");
					bool? dv_ = context.Operators.And(ds_, du_);

					return dv_;
				};
				IEnumerable<Encounter> bg_ = context.Operators.Where<Encounter>(be_, bf_);
				object bh_(Encounter @this)
				{
					CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime dx_ = context.Operators.End(dw_);

					return dx_;
				};
				IEnumerable<Encounter> bi_ = context.Operators.SortBy<Encounter>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bj_ = context.Operators.Last<Encounter>(bi_);
				CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_3_000.ToInterval(bj_?.Period);
				CqlDateTime bl_ = context.Operators.Start(bk_);
				CqlDateTime bn_ = context.Operators.Start(am_);
				bool? bo_ = context.Operators.Not((bool?)((bl_ ?? bn_) is null));
				bool? bp_ = context.Operators.And(bc_, bo_);
				Code<Encounter.EncounterStatus> bq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastEDOBTriage?.StatusElement?.Value);
				bool? br_ = context.Operators.Equal(bq_, "finished");
				bool? bs_ = context.Operators.And(bp_, br_);

				return bs_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				CqlInterval<CqlDateTime> dy_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				CqlDateTime dz_ = context.Operators.End(dy_);

				return dz_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_?.Period);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlValueSet n_ = this.Observation_Services();
			IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastObs)
			{
				CqlInterval<CqlDateTime> ea_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
				CqlDateTime eb_ = context.Operators.End(ea_);
				CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				CqlDateTime ed_ = context.Operators.Start(ec_);
				CqlQuantity ee_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ef_ = context.Operators.Subtract(ed_, ee_);
				CqlDateTime eh_ = context.Operators.Start(ec_);
				CqlInterval<CqlDateTime> ei_ = context.Operators.Interval(ef_, eh_, true, true);
				bool? ej_ = context.Operators.In<CqlDateTime>(eb_, ei_, null);
				CqlDateTime el_ = context.Operators.Start(ec_);
				bool? em_ = context.Operators.Not((bool?)(el_ is null));
				bool? en_ = context.Operators.And(ej_, em_);
				Code<Encounter.EncounterStatus> eo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
				bool? ep_ = context.Operators.Equal(eo_, "finished");
				bool? eq_ = context.Operators.And(en_, ep_);

				return eq_;
			};
			IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				CqlInterval<CqlDateTime> er_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				CqlDateTime es_ = context.Operators.End(er_);

				return es_;
			};
			IEnumerable<Encounter> s_ = context.Operators.SortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter t_ = context.Operators.Last<Encounter>(s_);
			CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_3_000.ToInterval(t_?.Period);
			CqlDateTime v_ = context.Operators.Start(u_);
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
			CqlDateTime x_ = context.Operators.Start(w_);
			CqlDateTime z_ = context.Operators.End(w_);
			CqlInterval<CqlDateTime> aa_ = context.Operators.Interval((m_ ?? (v_ ?? x_)), z_, true, true);

			return aa_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

	private IEnumerable<Encounter> Delivery_Encounter_with_Age_Range_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_Range();
		IEnumerable<Encounter> b_(Encounter EncounterWithAge)
		{
			CqlValueSet d_ = this.Delivery_Procedures();
			IEnumerable<Procedure> e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
			bool? f_(Procedure DeliveryProcedure)
			{
				bool? j_ = context.Operators.Equal(DeliveryProcedure?.StatusElement?.Value, "completed");
				object k_ = FHIRHelpers_4_3_000.ToValue(DeliveryProcedure?.Performed);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.toInterval(k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlInterval<CqlDateTime> n_ = this.hospitalizationWithEDOBTriageObservation(EncounterWithAge);
				bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, null);
				bool? p_ = context.Operators.And(j_, o_);

				return p_;
			};
			IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure DeliveryProcedure) => 
				EncounterWithAge;
			IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Age Range")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Age_Range() => 
		__Delivery_Encounter_with_Age_Range.Value;

    [CqlDeclaration("lastTimeOfDelivery")]
	public CqlDateTime lastTimeOfDelivery(Encounter TheEncounter)
	{
		CqlCode a_ = this.Date_and_time_of_obstetric_delivery();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation TimeOfDelivery)
		{
			object j_ = FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Value);
			bool? k_ = context.Operators.Not((bool?)((j_ as CqlDateTime) is null));
			Code<ObservationStatus> l_ = context.Operators.Convert<Code<ObservationStatus>>(TimeOfDelivery?.StatusElement?.Value);
			string m_ = context.Operators.Convert<string>(l_);
			string[] n_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? o_ = context.Operators.In<string>(m_, (n_ as IEnumerable<string>));
			bool? p_ = context.Operators.And(k_, o_);
			object q_()
			{
				bool z_()
				{
					object ac_ = FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Effective);
					bool ad_ = ac_ is CqlDateTime;

					return ad_;
				};
				bool aa_()
				{
					object ae_ = FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Effective);
					bool af_ = ae_ is CqlInterval<CqlDateTime>;

					return af_;
				};
				bool ab_()
				{
					object ag_ = FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Effective);
					bool ah_ = ag_ is CqlDateTime;

					return ah_;
				};
				if (z_())
				{
					object ai_ = FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Effective);

					return ((ai_ as CqlDateTime) as object);
				}
				else if (aa_())
				{
					object aj_ = FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Effective);

					return ((aj_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ab_())
				{
					object ak_ = FHIRHelpers_4_3_000.ToValue(TimeOfDelivery?.Effective);

					return ((ak_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime r_ = QICoreCommon_2_0_000.earliest(q_());
			CqlInterval<CqlDateTime> s_ = this.hospitalizationWithEDOBTriageObservation(TheEncounter);
			bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, null);
			bool? u_ = context.Operators.And(p_, t_);
			bool? x_ = context.Operators.In<CqlDateTime>((j_ as CqlDateTime), s_, null);
			bool? y_ = context.Operators.And(u_, x_);

			return y_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object al_()
			{
				bool an_()
				{
					object aq_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool ar_ = aq_ is CqlDateTime;

					return ar_;
				};
				bool ao_()
				{
					object as_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool at_ = as_ is CqlInterval<CqlDateTime>;

					return at_;
				};
				bool ap_()
				{
					object au_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool av_ = au_ is CqlDateTime;

					return av_;
				};
				if (an_())
				{
					object aw_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((aw_ as CqlDateTime) as object);
				}
				else if (ao_())
				{
					object ax_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ax_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ap_())
				{
					object ay_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ay_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime am_ = QICoreCommon_2_0_000.earliest(al_());

			return am_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		object i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (i_ as CqlDateTime);
	}

    [CqlDeclaration("lastEstimatedDeliveryDate")]
	public CqlDateTime lastEstimatedDeliveryDate(Encounter TheEncounter)
	{
		CqlCode a_ = this.Delivery_date_Estimated();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation EstimatedDateOfDelivery)
		{
			object j_ = FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Value);
			bool? k_ = context.Operators.Not((bool?)((j_ as CqlDateTime) is null));
			Code<ObservationStatus> l_ = context.Operators.Convert<Code<ObservationStatus>>(EstimatedDateOfDelivery?.StatusElement?.Value);
			string m_ = context.Operators.Convert<string>(l_);
			string[] n_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? o_ = context.Operators.In<string>(m_, (n_ as IEnumerable<string>));
			bool? p_ = context.Operators.And(k_, o_);
			object q_()
			{
				bool ac_()
				{
					object af_ = FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Effective);
					bool ag_ = af_ is CqlDateTime;

					return ag_;
				};
				bool ad_()
				{
					object ah_ = FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Effective);
					bool ai_ = ah_ is CqlInterval<CqlDateTime>;

					return ai_;
				};
				bool ae_()
				{
					object aj_ = FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Effective);
					bool ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				if (ac_())
				{
					object al_ = FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Effective);

					return ((al_ as CqlDateTime) as object);
				}
				else if (ad_())
				{
					object am_ = FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Effective);

					return ((am_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ae_())
				{
					object an_ = FHIRHelpers_4_3_000.ToValue(EstimatedDateOfDelivery?.Effective);

					return ((an_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime r_ = QICoreCommon_2_0_000.earliest(q_());
			CqlDateTime s_ = this.lastTimeOfDelivery(TheEncounter);
			CqlQuantity t_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime u_ = context.Operators.Subtract(s_, t_);
			CqlInterval<CqlDateTime> w_ = context.Operators.Interval(u_, s_, true, true);
			bool? x_ = context.Operators.In<CqlDateTime>(r_, w_, null);
			bool? z_ = context.Operators.Not((bool?)(s_ is null));
			bool? aa_ = context.Operators.And(x_, z_);
			bool? ab_ = context.Operators.And(p_, aa_);

			return ab_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ao_()
			{
				bool aq_()
				{
					object at_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool au_ = at_ is CqlDateTime;

					return au_;
				};
				bool ar_()
				{
					object av_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool aw_ = av_ is CqlInterval<CqlDateTime>;

					return aw_;
				};
				bool as_()
				{
					object ax_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool ay_ = ax_ is CqlDateTime;

					return ay_;
				};
				if (aq_())
				{
					object az_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((az_ as CqlDateTime) as object);
				}
				else if (ar_())
				{
					object ba_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ba_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (as_())
				{
					object bb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((bb_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime ap_ = QICoreCommon_2_0_000.earliest(ao_());

			return ap_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		object i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (i_ as CqlDateTime);
	}

    [CqlDeclaration("calculatedGestationalAge")]
	public int? calculatedGestationalAge(Encounter TheEncounter)
	{
		CqlDateTime a_ = this.lastTimeOfDelivery(TheEncounter);
		CqlDateTime b_ = this.lastEstimatedDeliveryDate(TheEncounter);
		int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");
		int? d_ = context.Operators.Subtract(280, c_);
		int? e_ = context.Operators.TruncatedDivide(d_, 7);

		return e_;
	}

	private IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM> Variable_Calculated_Gestational_Age_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounter_with_Age_Range();
		Tuple_CDQdAjUGdePbWTVfePeZUXKFM b_(Encounter DeliveryEncounter)
		{
			int? d_ = this.calculatedGestationalAge(DeliveryEncounter);
			Tuple_CDQdAjUGdePbWTVfePeZUXKFM e_ = new Tuple_CDQdAjUGdePbWTVfePeZUXKFM
			{
				EncounterID = DeliveryEncounter?.IdElement?.Value,
				CalculatedCGA = d_,
			};

			return e_;
		};
		IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM> c_ = context.Operators.Select<Encounter, Tuple_CDQdAjUGdePbWTVfePeZUXKFM>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Variable Calculated Gestational Age")]
	public IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM> Variable_Calculated_Gestational_Age() => 
		__Variable_Calculated_Gestational_Age.Value;

    [CqlDeclaration("lastEstimatedGestationalAge")]
	public CqlQuantity lastEstimatedGestationalAge(Encounter TheEncounter)
	{
		CqlValueSet a_ = this.Estimated_Gestational_Age_at_Delivery();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation EstimatedGestationalAge)
		{
			object i_()
			{
				bool ao_()
				{
					object ar_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);
					bool as_ = ar_ is CqlDateTime;

					return as_;
				};
				bool ap_()
				{
					object at_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);
					bool au_ = at_ is CqlInterval<CqlDateTime>;

					return au_;
				};
				bool aq_()
				{
					object av_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);
					bool aw_ = av_ is CqlDateTime;

					return aw_;
				};
				if (ao_())
				{
					object ax_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((ax_ as CqlDateTime) as object);
				}
				else if (ap_())
				{
					object ay_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((ay_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (aq_())
				{
					object az_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((az_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime j_ = QICoreCommon_2_0_000.earliest(i_());
			CqlDateTime k_ = this.lastTimeOfDelivery(TheEncounter);
			CqlQuantity l_ = context.Operators.Quantity(24m, "hours");
			CqlDateTime m_ = context.Operators.Subtract(k_, l_);
			CqlInterval<CqlDateTime> o_ = context.Operators.Interval(m_, k_, true, true);
			bool? p_ = context.Operators.In<CqlDateTime>(j_, o_, null);
			bool? r_ = context.Operators.Not((bool?)(k_ is null));
			bool? s_ = context.Operators.And(p_, r_);
			object t_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Value);
			bool? u_ = context.Operators.Not((bool?)(t_ is null));
			bool? v_ = context.Operators.And(s_, u_);
			Code<ObservationStatus> w_ = context.Operators.Convert<Code<ObservationStatus>>(EstimatedGestationalAge?.StatusElement?.Value);
			string x_ = context.Operators.Convert<string>(w_);
			string[] y_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? z_ = context.Operators.In<string>(x_, (y_ as IEnumerable<string>));
			bool? aa_ = context.Operators.And(v_, z_);
			object ab_()
			{
				bool ba_()
				{
					object bd_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);
					bool be_ = bd_ is CqlDateTime;

					return be_;
				};
				bool bb_()
				{
					object bf_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);
					bool bg_ = bf_ is CqlInterval<CqlDateTime>;

					return bg_;
				};
				bool bc_()
				{
					object bh_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);
					bool bi_ = bh_ is CqlDateTime;

					return bi_;
				};
				if (ba_())
				{
					object bj_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((bj_ as CqlDateTime) as object);
				}
				else if (bb_())
				{
					object bk_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((bk_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bc_())
				{
					object bl_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((bl_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime ac_ = QICoreCommon_2_0_000.earliest(ab_());
			bool? ae_ = context.Operators.SameAs(ac_, k_, "day");
			object af_()
			{
				bool bm_()
				{
					object bp_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);
					bool bq_ = bp_ is CqlDateTime;

					return bq_;
				};
				bool bn_()
				{
					object br_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);
					bool bs_ = br_ is CqlInterval<CqlDateTime>;

					return bs_;
				};
				bool bo_()
				{
					object bt_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);
					bool bu_ = bt_ is CqlDateTime;

					return bu_;
				};
				if (bm_())
				{
					object bv_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((bv_ as CqlDateTime) as object);
				}
				else if (bn_())
				{
					object bw_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((bw_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bo_())
				{
					object bx_ = FHIRHelpers_4_3_000.ToValue(EstimatedGestationalAge?.Effective);

					return ((bx_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime ag_ = QICoreCommon_2_0_000.earliest(af_());
			CqlInterval<CqlDateTime> ah_ = this.hospitalizationWithEDOBTriageObservation(TheEncounter);
			bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ah_, null);
			bool? aj_ = context.Operators.And(ae_, ai_);
			bool? al_ = context.Operators.Not((bool?)(t_ is null));
			bool? am_ = context.Operators.And(aj_, al_);
			bool? an_ = context.Operators.Or(aa_, am_);

			return an_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		object e_(Observation @this)
		{
			object by_()
			{
				bool ca_()
				{
					object cd_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool ce_ = cd_ is CqlDateTime;

					return ce_;
				};
				bool cb_()
				{
					object cf_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool cg_ = cf_ is CqlInterval<CqlDateTime>;

					return cg_;
				};
				bool cc_()
				{
					object ch_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool ci_ = ch_ is CqlDateTime;

					return ci_;
				};
				if (ca_())
				{
					object cj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((cj_ as CqlDateTime) as object);
				}
				else if (cb_())
				{
					object ck_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ck_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (cc_())
				{
					object cl_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((cl_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime bz_ = QICoreCommon_2_0_000.earliest(by_());

			return bz_;
		};
		IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Observation g_ = context.Operators.Last<Observation>(f_);
		object h_ = FHIRHelpers_4_3_000.ToValue(g_?.Value);

		return (h_ as CqlQuantity);
	}

}
