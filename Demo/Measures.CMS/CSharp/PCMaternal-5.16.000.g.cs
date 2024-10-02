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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
    internal Lazy<IEnumerable<(string EncounterID, int? CalculatedCGA)?>> __Variable_Calculated_Gestational_Age;

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
        __Variable_Calculated_Gestational_Age = new Lazy<IEnumerable<(string EncounterID, int? CalculatedCGA)?>>(this.Variable_Calculated_Gestational_Age_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Delivery_Procedures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", default);

    [CqlDeclaration("Delivery Procedures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59")]
	public CqlValueSet Delivery_Procedures() => 
		__Delivery_Procedures.Value;

	private CqlValueSet ED_Visit_and_OB_Triage_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", default);

    [CqlDeclaration("ED Visit and OB Triage")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369")]
	public CqlValueSet ED_Visit_and_OB_Triage() => 
		__ED_Visit_and_OB_Triage.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Estimated_Gestational_Age_at_Delivery_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26", default);

    [CqlDeclaration("Estimated Gestational Age at Delivery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26")]
	public CqlValueSet Estimated_Gestational_Age_at_Delivery() => 
		__Estimated_Gestational_Age_at_Delivery.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlCode Date_and_time_of_obstetric_delivery_Value() => 
		new CqlCode("93857-1", "http://loinc.org", default, default);

    [CqlDeclaration("Date and time of obstetric delivery")]
	public CqlCode Date_and_time_of_obstetric_delivery() => 
		__Date_and_time_of_obstetric_delivery.Value;

	private CqlCode Delivery_date_Estimated_Value() => 
		new CqlCode("11778-8", "http://loinc.org", default, default);

    [CqlDeclaration("Delivery date Estimated")]
	public CqlCode Delivery_date_Estimated() => 
		__Delivery_date_Estimated.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("93857-1", "http://loinc.org", default, default),
			new CqlCode("11778-8", "http://loinc.org", default, default),
		];

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
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
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
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDate g_ = context.Operators.ConvertStringToDate(f_);
			Period h_ = InpatientEncounter?.Period;
			CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_3_000.ToInterval(h_);
			CqlDateTime j_ = context.Operators.Start(i_);
			CqlDate k_ = context.Operators.DateFrom(j_);
			int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
			CqlInterval<int?> m_ = context.Operators.Interval(8, 65, true, false);
			bool? n_ = context.Operators.In<int?>(l_, m_, default);

			return n_;
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
		Encounter[] a_ = [
			TheEncounter,
		];
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.ED_Visit_and_OB_Triage();
			IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
			bool? g_(Encounter LastEDOBTriage)
			{
				Period af_ = LastEDOBTriage?.Period;
				CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_3_000.ToInterval(af_);
				CqlDateTime ah_ = context.Operators.End(ag_);
				CqlValueSet ai_ = this.Observation_Services();
				IEnumerable<Encounter> aj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
				bool? ak_(Encounter LastObs)
				{
					Period cg_ = LastObs?.Period;
					CqlInterval<CqlDateTime> ch_ = FHIRHelpers_4_3_000.ToInterval(cg_);
					CqlDateTime ci_ = context.Operators.End(ch_);
					Period cj_ = Visit?.Period;
					CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_3_000.ToInterval(cj_);
					CqlDateTime cl_ = context.Operators.Start(ck_);
					CqlQuantity cm_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime cn_ = context.Operators.Subtract(cl_, cm_);
					CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_3_000.ToInterval(cj_);
					CqlDateTime cq_ = context.Operators.Start(cp_);
					CqlInterval<CqlDateTime> cr_ = context.Operators.Interval(cn_, cq_, true, true);
					bool? cs_ = context.Operators.In<CqlDateTime>(ci_, cr_, default);
					CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_3_000.ToInterval(cj_);
					CqlDateTime cv_ = context.Operators.Start(cu_);
					bool? cw_ = context.Operators.Not((bool?)(cv_ is null));
					bool? cx_ = context.Operators.And(cs_, cw_);
					Code<Encounter.EncounterStatus> cy_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? cz_ = cy_?.Value;
					Code<Encounter.EncounterStatus> da_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cz_);
					bool? db_ = context.Operators.Equal(da_, "finished");
					bool? dc_ = context.Operators.And(cx_, db_);

					return dc_;
				};
				IEnumerable<Encounter> al_ = context.Operators.Where<Encounter>(aj_, ak_);
				object am_(Encounter @this)
				{
					Period dd_ = @this?.Period;
					CqlInterval<CqlDateTime> de_ = FHIRHelpers_4_3_000.ToInterval(dd_);
					CqlDateTime df_ = context.Operators.End(de_);

					return df_;
				};
				IEnumerable<Encounter> an_ = context.Operators.SortBy<Encounter>(al_, am_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ao_ = context.Operators.Last<Encounter>(an_);
				Period ap_ = ao_?.Period;
				CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_3_000.ToInterval(ap_);
				CqlDateTime ar_ = context.Operators.Start(aq_);
				Period as_ = Visit?.Period;
				CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_3_000.ToInterval(as_);
				CqlDateTime au_ = context.Operators.Start(at_);
				CqlQuantity av_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime aw_ = context.Operators.Subtract(ar_ ?? au_, av_);
				IEnumerable<Encounter> ay_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
				bool? az_(Encounter LastObs)
				{
					Period dg_ = LastObs?.Period;
					CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_3_000.ToInterval(dg_);
					CqlDateTime di_ = context.Operators.End(dh_);
					Period dj_ = Visit?.Period;
					CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_3_000.ToInterval(dj_);
					CqlDateTime dl_ = context.Operators.Start(dk_);
					CqlQuantity dm_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dn_ = context.Operators.Subtract(dl_, dm_);
					CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_3_000.ToInterval(dj_);
					CqlDateTime dq_ = context.Operators.Start(dp_);
					CqlInterval<CqlDateTime> dr_ = context.Operators.Interval(dn_, dq_, true, true);
					bool? ds_ = context.Operators.In<CqlDateTime>(di_, dr_, default);
					CqlInterval<CqlDateTime> du_ = FHIRHelpers_4_3_000.ToInterval(dj_);
					CqlDateTime dv_ = context.Operators.Start(du_);
					bool? dw_ = context.Operators.Not((bool?)(dv_ is null));
					bool? dx_ = context.Operators.And(ds_, dw_);
					Code<Encounter.EncounterStatus> dy_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? dz_ = dy_?.Value;
					Code<Encounter.EncounterStatus> ea_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dz_);
					bool? eb_ = context.Operators.Equal(ea_, "finished");
					bool? ec_ = context.Operators.And(dx_, eb_);

					return ec_;
				};
				IEnumerable<Encounter> ba_ = context.Operators.Where<Encounter>(ay_, az_);
				object bb_(Encounter @this)
				{
					Period ed_ = @this?.Period;
					CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_3_000.ToInterval(ed_);
					CqlDateTime ef_ = context.Operators.End(ee_);

					return ef_;
				};
				IEnumerable<Encounter> bc_ = context.Operators.SortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bd_ = context.Operators.Last<Encounter>(bc_);
				Period be_ = bd_?.Period;
				CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_3_000.ToInterval(be_);
				CqlDateTime bg_ = context.Operators.Start(bf_);
				CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_3_000.ToInterval(as_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlInterval<CqlDateTime> bk_ = context.Operators.Interval(aw_, bg_ ?? bj_, true, true);
				bool? bl_ = context.Operators.In<CqlDateTime>(ah_, bk_, default);
				IEnumerable<Encounter> bn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
				bool? bo_(Encounter LastObs)
				{
					Period eg_ = LastObs?.Period;
					CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_3_000.ToInterval(eg_);
					CqlDateTime ei_ = context.Operators.End(eh_);
					Period ej_ = Visit?.Period;
					CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_3_000.ToInterval(ej_);
					CqlDateTime el_ = context.Operators.Start(ek_);
					CqlQuantity em_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime en_ = context.Operators.Subtract(el_, em_);
					CqlInterval<CqlDateTime> ep_ = FHIRHelpers_4_3_000.ToInterval(ej_);
					CqlDateTime eq_ = context.Operators.Start(ep_);
					CqlInterval<CqlDateTime> er_ = context.Operators.Interval(en_, eq_, true, true);
					bool? es_ = context.Operators.In<CqlDateTime>(ei_, er_, default);
					CqlInterval<CqlDateTime> eu_ = FHIRHelpers_4_3_000.ToInterval(ej_);
					CqlDateTime ev_ = context.Operators.Start(eu_);
					bool? ew_ = context.Operators.Not((bool?)(ev_ is null));
					bool? ex_ = context.Operators.And(es_, ew_);
					Code<Encounter.EncounterStatus> ey_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? ez_ = ey_?.Value;
					Code<Encounter.EncounterStatus> fa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ez_);
					bool? fb_ = context.Operators.Equal(fa_, "finished");
					bool? fc_ = context.Operators.And(ex_, fb_);

					return fc_;
				};
				IEnumerable<Encounter> bp_ = context.Operators.Where<Encounter>(bn_, bo_);
				object bq_(Encounter @this)
				{
					Period fd_ = @this?.Period;
					CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_3_000.ToInterval(fd_);
					CqlDateTime ff_ = context.Operators.End(fe_);

					return ff_;
				};
				IEnumerable<Encounter> br_ = context.Operators.SortBy<Encounter>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bs_ = context.Operators.Last<Encounter>(br_);
				Period bt_ = bs_?.Period;
				CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_3_000.ToInterval(bt_);
				CqlDateTime bv_ = context.Operators.Start(bu_);
				CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_3_000.ToInterval(as_);
				CqlDateTime by_ = context.Operators.Start(bx_);
				bool? bz_ = context.Operators.Not((bool?)((bv_ ?? by_) is null));
				bool? ca_ = context.Operators.And(bl_, bz_);
				Code<Encounter.EncounterStatus> cb_ = LastEDOBTriage?.StatusElement;
				Encounter.EncounterStatus? cc_ = cb_?.Value;
				Code<Encounter.EncounterStatus> cd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cc_);
				bool? ce_ = context.Operators.Equal(cd_, "finished");
				bool? cf_ = context.Operators.And(ca_, ce_);

				return cf_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				Period fg_ = @this?.Period;
				CqlInterval<CqlDateTime> fh_ = FHIRHelpers_4_3_000.ToInterval(fg_);
				CqlDateTime fi_ = context.Operators.End(fh_);

				return fi_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			Period l_ = k_?.Period;
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlValueSet o_ = this.Observation_Services();
			IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
			bool? q_(Encounter LastObs)
			{
				Period fj_ = LastObs?.Period;
				CqlInterval<CqlDateTime> fk_ = FHIRHelpers_4_3_000.ToInterval(fj_);
				CqlDateTime fl_ = context.Operators.End(fk_);
				Period fm_ = Visit?.Period;
				CqlInterval<CqlDateTime> fn_ = FHIRHelpers_4_3_000.ToInterval(fm_);
				CqlDateTime fo_ = context.Operators.Start(fn_);
				CqlQuantity fp_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime fq_ = context.Operators.Subtract(fo_, fp_);
				CqlInterval<CqlDateTime> fs_ = FHIRHelpers_4_3_000.ToInterval(fm_);
				CqlDateTime ft_ = context.Operators.Start(fs_);
				CqlInterval<CqlDateTime> fu_ = context.Operators.Interval(fq_, ft_, true, true);
				bool? fv_ = context.Operators.In<CqlDateTime>(fl_, fu_, default);
				CqlInterval<CqlDateTime> fx_ = FHIRHelpers_4_3_000.ToInterval(fm_);
				CqlDateTime fy_ = context.Operators.Start(fx_);
				bool? fz_ = context.Operators.Not((bool?)(fy_ is null));
				bool? ga_ = context.Operators.And(fv_, fz_);
				Code<Encounter.EncounterStatus> gb_ = LastObs?.StatusElement;
				Encounter.EncounterStatus? gc_ = gb_?.Value;
				Code<Encounter.EncounterStatus> gd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gc_);
				bool? ge_ = context.Operators.Equal(gd_, "finished");
				bool? gf_ = context.Operators.And(ga_, ge_);

				return gf_;
			};
			IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				Period gg_ = @this?.Period;
				CqlInterval<CqlDateTime> gh_ = FHIRHelpers_4_3_000.ToInterval(gg_);
				CqlDateTime gi_ = context.Operators.End(gh_);

				return gi_;
			};
			IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter u_ = context.Operators.Last<Encounter>(t_);
			Period v_ = u_?.Period;
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_3_000.ToInterval(v_);
			CqlDateTime x_ = context.Operators.Start(w_);
			Period y_ = Visit?.Period;
			CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_3_000.ToInterval(y_);
			CqlDateTime aa_ = context.Operators.Start(z_);
			CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_3_000.ToInterval(y_);
			CqlDateTime ad_ = context.Operators.End(ac_);
			CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ad_, true, true);

			return ae_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

	private IEnumerable<Encounter> Delivery_Encounter_with_Age_Range_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_Range();
		IEnumerable<Encounter> b_(Encounter EncounterWithAge)
		{
			CqlValueSet d_ = this.Delivery_Procedures();
			IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			bool? f_(Procedure DeliveryProcedure)
			{
				Code<EventStatus> j_ = DeliveryProcedure?.StatusElement;
				EventStatus? k_ = j_?.Value;
				string l_ = context.Operators.Convert<string>(k_);
				bool? m_ = context.Operators.Equal(l_, "completed");
				DataType n_ = DeliveryProcedure?.Performed;
				object o_ = FHIRHelpers_4_3_000.ToValue(n_);
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.toInterval(o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				CqlInterval<CqlDateTime> r_ = this.hospitalizationWithEDOBTriageObservation(EncounterWithAge);
				bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, default);
				bool? t_ = context.Operators.And(m_, s_);

				return t_;
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
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		bool? d_(Observation TimeOfDelivery)
		{
			DataType k_ = TimeOfDelivery?.Value;
			object l_ = FHIRHelpers_4_3_000.ToValue(k_);
			bool? m_ = context.Operators.Not((bool?)((l_ as CqlDateTime) is null));
			Code<ObservationStatus> n_ = TimeOfDelivery?.StatusElement;
			ObservationStatus? o_ = n_?.Value;
			Code<ObservationStatus> p_ = context.Operators.Convert<Code<ObservationStatus>>(o_);
			string q_ = context.Operators.Convert<string>(p_);
			string[] r_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? s_ = context.Operators.In<string>(q_, r_ as IEnumerable<string>);
			bool? t_ = context.Operators.And(m_, s_);
			object u_()
			{
				bool ae_()
				{
					DataType ah_ = TimeOfDelivery?.Effective;
					object ai_ = FHIRHelpers_4_3_000.ToValue(ah_);
					bool aj_ = ai_ is CqlDateTime;

					return aj_;
				};
				bool af_()
				{
					DataType ak_ = TimeOfDelivery?.Effective;
					object al_ = FHIRHelpers_4_3_000.ToValue(ak_);
					bool am_ = al_ is CqlInterval<CqlDateTime>;

					return am_;
				};
				bool ag_()
				{
					DataType an_ = TimeOfDelivery?.Effective;
					object ao_ = FHIRHelpers_4_3_000.ToValue(an_);
					bool ap_ = ao_ is CqlDateTime;

					return ap_;
				};
				if (ae_())
				{
					DataType aq_ = TimeOfDelivery?.Effective;
					object ar_ = FHIRHelpers_4_3_000.ToValue(aq_);

					return (ar_ as CqlDateTime) as object;
				}
				else if (af_())
				{
					DataType as_ = TimeOfDelivery?.Effective;
					object at_ = FHIRHelpers_4_3_000.ToValue(as_);

					return (at_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (ag_())
				{
					DataType au_ = TimeOfDelivery?.Effective;
					object av_ = FHIRHelpers_4_3_000.ToValue(au_);

					return (av_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime v_ = QICoreCommon_2_0_000.earliest(u_());
			CqlInterval<CqlDateTime> w_ = this.hospitalizationWithEDOBTriageObservation(TheEncounter);
			bool? x_ = context.Operators.In<CqlDateTime>(v_, w_, default);
			bool? y_ = context.Operators.And(t_, x_);
			object aa_ = FHIRHelpers_4_3_000.ToValue(k_);
			bool? ac_ = context.Operators.In<CqlDateTime>(aa_ as CqlDateTime, w_, default);
			bool? ad_ = context.Operators.And(y_, ac_);

			return ad_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object aw_()
			{
				bool ay_()
				{
					DataType bb_ = @this?.Effective;
					object bc_ = FHIRHelpers_4_3_000.ToValue(bb_);
					bool bd_ = bc_ is CqlDateTime;

					return bd_;
				};
				bool az_()
				{
					DataType be_ = @this?.Effective;
					object bf_ = FHIRHelpers_4_3_000.ToValue(be_);
					bool bg_ = bf_ is CqlInterval<CqlDateTime>;

					return bg_;
				};
				bool ba_()
				{
					DataType bh_ = @this?.Effective;
					object bi_ = FHIRHelpers_4_3_000.ToValue(bh_);
					bool bj_ = bi_ is CqlDateTime;

					return bj_;
				};
				if (ay_())
				{
					DataType bk_ = @this?.Effective;
					object bl_ = FHIRHelpers_4_3_000.ToValue(bk_);

					return (bl_ as CqlDateTime) as object;
				}
				else if (az_())
				{
					DataType bm_ = @this?.Effective;
					object bn_ = FHIRHelpers_4_3_000.ToValue(bm_);

					return (bn_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (ba_())
				{
					DataType bo_ = @this?.Effective;
					object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);

					return (bp_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime ax_ = QICoreCommon_2_0_000.earliest(aw_());

			return ax_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);

		return j_ as CqlDateTime;
	}

    [CqlDeclaration("lastEstimatedDeliveryDate")]
	public CqlDateTime lastEstimatedDeliveryDate(Encounter TheEncounter)
	{
		CqlCode a_ = this.Delivery_date_Estimated();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		bool? d_(Observation EstimatedDateOfDelivery)
		{
			DataType k_ = EstimatedDateOfDelivery?.Value;
			object l_ = FHIRHelpers_4_3_000.ToValue(k_);
			bool? m_ = context.Operators.Not((bool?)((l_ as CqlDateTime) is null));
			Code<ObservationStatus> n_ = EstimatedDateOfDelivery?.StatusElement;
			ObservationStatus? o_ = n_?.Value;
			Code<ObservationStatus> p_ = context.Operators.Convert<Code<ObservationStatus>>(o_);
			string q_ = context.Operators.Convert<string>(p_);
			string[] r_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? s_ = context.Operators.In<string>(q_, r_ as IEnumerable<string>);
			bool? t_ = context.Operators.And(m_, s_);
			object u_()
			{
				bool ag_()
				{
					DataType aj_ = EstimatedDateOfDelivery?.Effective;
					object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
					bool al_ = ak_ is CqlDateTime;

					return al_;
				};
				bool ah_()
				{
					DataType am_ = EstimatedDateOfDelivery?.Effective;
					object an_ = FHIRHelpers_4_3_000.ToValue(am_);
					bool ao_ = an_ is CqlInterval<CqlDateTime>;

					return ao_;
				};
				bool ai_()
				{
					DataType ap_ = EstimatedDateOfDelivery?.Effective;
					object aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
					bool ar_ = aq_ is CqlDateTime;

					return ar_;
				};
				if (ag_())
				{
					DataType as_ = EstimatedDateOfDelivery?.Effective;
					object at_ = FHIRHelpers_4_3_000.ToValue(as_);

					return (at_ as CqlDateTime) as object;
				}
				else if (ah_())
				{
					DataType au_ = EstimatedDateOfDelivery?.Effective;
					object av_ = FHIRHelpers_4_3_000.ToValue(au_);

					return (av_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (ai_())
				{
					DataType aw_ = EstimatedDateOfDelivery?.Effective;
					object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);

					return (ax_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime v_ = QICoreCommon_2_0_000.earliest(u_());
			CqlDateTime w_ = this.lastTimeOfDelivery(TheEncounter);
			CqlQuantity x_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime y_ = context.Operators.Subtract(w_, x_);
			CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(y_, w_, true, true);
			bool? ab_ = context.Operators.In<CqlDateTime>(v_, aa_, default);
			bool? ad_ = context.Operators.Not((bool?)(w_ is null));
			bool? ae_ = context.Operators.And(ab_, ad_);
			bool? af_ = context.Operators.And(t_, ae_);

			return af_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ay_()
			{
				bool ba_()
				{
					DataType bd_ = @this?.Effective;
					object be_ = FHIRHelpers_4_3_000.ToValue(bd_);
					bool bf_ = be_ is CqlDateTime;

					return bf_;
				};
				bool bb_()
				{
					DataType bg_ = @this?.Effective;
					object bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
					bool bi_ = bh_ is CqlInterval<CqlDateTime>;

					return bi_;
				};
				bool bc_()
				{
					DataType bj_ = @this?.Effective;
					object bk_ = FHIRHelpers_4_3_000.ToValue(bj_);
					bool bl_ = bk_ is CqlDateTime;

					return bl_;
				};
				if (ba_())
				{
					DataType bm_ = @this?.Effective;
					object bn_ = FHIRHelpers_4_3_000.ToValue(bm_);

					return (bn_ as CqlDateTime) as object;
				}
				else if (bb_())
				{
					DataType bo_ = @this?.Effective;
					object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);

					return (bp_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (bc_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);

					return (br_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime az_ = QICoreCommon_2_0_000.earliest(ay_());

			return az_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);

		return j_ as CqlDateTime;
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

	private IEnumerable<(string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounter_with_Age_Range();
		(string EncounterID, int? CalculatedCGA)? b_(Encounter DeliveryEncounter)
		{
			Id d_ = DeliveryEncounter?.IdElement;
			string e_ = d_?.Value;
			int? f_ = this.calculatedGestationalAge(DeliveryEncounter);
			(string EncounterID, int? CalculatedCGA)? g_ = (e_, f_);

			return g_;
		};
		IEnumerable<(string EncounterID, int? CalculatedCGA)?> c_ = context.Operators.Select<Encounter, (string EncounterID, int? CalculatedCGA)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Variable Calculated Gestational Age")]
	public IEnumerable<(string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age() => 
		__Variable_Calculated_Gestational_Age.Value;

    [CqlDeclaration("lastEstimatedGestationalAge")]
	public CqlQuantity lastEstimatedGestationalAge(Encounter TheEncounter)
	{
		CqlValueSet a_ = this.Estimated_Gestational_Age_at_Delivery();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		bool? c_(Observation EstimatedGestationalAge)
		{
			object j_()
			{
				bool at_()
				{
					DataType aw_ = EstimatedGestationalAge?.Effective;
					object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
					bool ay_ = ax_ is CqlDateTime;

					return ay_;
				};
				bool au_()
				{
					DataType az_ = EstimatedGestationalAge?.Effective;
					object ba_ = FHIRHelpers_4_3_000.ToValue(az_);
					bool bb_ = ba_ is CqlInterval<CqlDateTime>;

					return bb_;
				};
				bool av_()
				{
					DataType bc_ = EstimatedGestationalAge?.Effective;
					object bd_ = FHIRHelpers_4_3_000.ToValue(bc_);
					bool be_ = bd_ is CqlDateTime;

					return be_;
				};
				if (at_())
				{
					DataType bf_ = EstimatedGestationalAge?.Effective;
					object bg_ = FHIRHelpers_4_3_000.ToValue(bf_);

					return (bg_ as CqlDateTime) as object;
				}
				else if (au_())
				{
					DataType bh_ = EstimatedGestationalAge?.Effective;
					object bi_ = FHIRHelpers_4_3_000.ToValue(bh_);

					return (bi_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (av_())
				{
					DataType bj_ = EstimatedGestationalAge?.Effective;
					object bk_ = FHIRHelpers_4_3_000.ToValue(bj_);

					return (bk_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime k_ = QICoreCommon_2_0_000.earliest(j_());
			CqlDateTime l_ = this.lastTimeOfDelivery(TheEncounter);
			CqlQuantity m_ = context.Operators.Quantity(24m, "hours");
			CqlDateTime n_ = context.Operators.Subtract(l_, m_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(n_, l_, true, true);
			bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, default);
			bool? s_ = context.Operators.Not((bool?)(l_ is null));
			bool? t_ = context.Operators.And(q_, s_);
			DataType u_ = EstimatedGestationalAge?.Value;
			object v_ = FHIRHelpers_4_3_000.ToValue(u_);
			bool? w_ = context.Operators.Not((bool?)(v_ is null));
			bool? x_ = context.Operators.And(t_, w_);
			Code<ObservationStatus> y_ = EstimatedGestationalAge?.StatusElement;
			ObservationStatus? z_ = y_?.Value;
			Code<ObservationStatus> aa_ = context.Operators.Convert<Code<ObservationStatus>>(z_);
			string ab_ = context.Operators.Convert<string>(aa_);
			string[] ac_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? ad_ = context.Operators.In<string>(ab_, ac_ as IEnumerable<string>);
			bool? ae_ = context.Operators.And(x_, ad_);
			object af_()
			{
				bool bl_()
				{
					DataType bo_ = EstimatedGestationalAge?.Effective;
					object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);
					bool bq_ = bp_ is CqlDateTime;

					return bq_;
				};
				bool bm_()
				{
					DataType br_ = EstimatedGestationalAge?.Effective;
					object bs_ = FHIRHelpers_4_3_000.ToValue(br_);
					bool bt_ = bs_ is CqlInterval<CqlDateTime>;

					return bt_;
				};
				bool bn_()
				{
					DataType bu_ = EstimatedGestationalAge?.Effective;
					object bv_ = FHIRHelpers_4_3_000.ToValue(bu_);
					bool bw_ = bv_ is CqlDateTime;

					return bw_;
				};
				if (bl_())
				{
					DataType bx_ = EstimatedGestationalAge?.Effective;
					object by_ = FHIRHelpers_4_3_000.ToValue(bx_);

					return (by_ as CqlDateTime) as object;
				}
				else if (bm_())
				{
					DataType bz_ = EstimatedGestationalAge?.Effective;
					object ca_ = FHIRHelpers_4_3_000.ToValue(bz_);

					return (ca_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (bn_())
				{
					DataType cb_ = EstimatedGestationalAge?.Effective;
					object cc_ = FHIRHelpers_4_3_000.ToValue(cb_);

					return (cc_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime ag_ = QICoreCommon_2_0_000.earliest(af_());
			bool? ai_ = context.Operators.SameAs(ag_, l_, "day");
			object aj_()
			{
				bool cd_()
				{
					DataType cg_ = EstimatedGestationalAge?.Effective;
					object ch_ = FHIRHelpers_4_3_000.ToValue(cg_);
					bool ci_ = ch_ is CqlDateTime;

					return ci_;
				};
				bool ce_()
				{
					DataType cj_ = EstimatedGestationalAge?.Effective;
					object ck_ = FHIRHelpers_4_3_000.ToValue(cj_);
					bool cl_ = ck_ is CqlInterval<CqlDateTime>;

					return cl_;
				};
				bool cf_()
				{
					DataType cm_ = EstimatedGestationalAge?.Effective;
					object cn_ = FHIRHelpers_4_3_000.ToValue(cm_);
					bool co_ = cn_ is CqlDateTime;

					return co_;
				};
				if (cd_())
				{
					DataType cp_ = EstimatedGestationalAge?.Effective;
					object cq_ = FHIRHelpers_4_3_000.ToValue(cp_);

					return (cq_ as CqlDateTime) as object;
				}
				else if (ce_())
				{
					DataType cr_ = EstimatedGestationalAge?.Effective;
					object cs_ = FHIRHelpers_4_3_000.ToValue(cr_);

					return (cs_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (cf_())
				{
					DataType ct_ = EstimatedGestationalAge?.Effective;
					object cu_ = FHIRHelpers_4_3_000.ToValue(ct_);

					return (cu_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime ak_ = QICoreCommon_2_0_000.earliest(aj_());
			CqlInterval<CqlDateTime> al_ = this.hospitalizationWithEDOBTriageObservation(TheEncounter);
			bool? am_ = context.Operators.In<CqlDateTime>(ak_, al_, default);
			bool? an_ = context.Operators.And(ai_, am_);
			object ap_ = FHIRHelpers_4_3_000.ToValue(u_);
			bool? aq_ = context.Operators.Not((bool?)(ap_ is null));
			bool? ar_ = context.Operators.And(an_, aq_);
			bool? as_ = context.Operators.Or(ae_, ar_);

			return as_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		object e_(Observation @this)
		{
			object cv_()
			{
				bool cx_()
				{
					DataType da_ = @this?.Effective;
					object db_ = FHIRHelpers_4_3_000.ToValue(da_);
					bool dc_ = db_ is CqlDateTime;

					return dc_;
				};
				bool cy_()
				{
					DataType dd_ = @this?.Effective;
					object de_ = FHIRHelpers_4_3_000.ToValue(dd_);
					bool df_ = de_ is CqlInterval<CqlDateTime>;

					return df_;
				};
				bool cz_()
				{
					DataType dg_ = @this?.Effective;
					object dh_ = FHIRHelpers_4_3_000.ToValue(dg_);
					bool di_ = dh_ is CqlDateTime;

					return di_;
				};
				if (cx_())
				{
					DataType dj_ = @this?.Effective;
					object dk_ = FHIRHelpers_4_3_000.ToValue(dj_);

					return (dk_ as CqlDateTime) as object;
				}
				else if (cy_())
				{
					DataType dl_ = @this?.Effective;
					object dm_ = FHIRHelpers_4_3_000.ToValue(dl_);

					return (dm_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (cz_())
				{
					DataType dn_ = @this?.Effective;
					object do_ = FHIRHelpers_4_3_000.ToValue(dn_);

					return (do_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime cw_ = QICoreCommon_2_0_000.earliest(cv_());

			return cw_;
		};
		IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Observation g_ = context.Operators.Last<Observation>(f_);
		DataType h_ = g_?.Value;
		object i_ = FHIRHelpers_4_3_000.ToValue(h_);

		return i_ as CqlQuantity;
	}

}
