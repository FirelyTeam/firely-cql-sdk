using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

#pragma warning disable CS9113 // Parameter is unread.

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
public static partial class HybridHWMFHIR_0_102_005ServiceCollectionExtensions
{
    public static IServiceCollection AddHybridHWMFHIR_0_102_005(this IServiceCollection services)
    {
        services.TryAddSingleton<HybridHWMFHIR_0_102_005>();
        services.AddFHIRHelpers_4_0_001();
        services.AddSupplementalDataElementsFHIR4_2_0_000();
        services.AddMATGlobalCommonFunctionsFHIR4_6_1_000();
        return services;
    }
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("HybridHWMFHIR", "0.102.005")]
public partial class HybridHWMFHIR_0_102_005(
    FHIRHelpers_4_0_001 fhirHelpers_4_0_001,
    SupplementalDataElementsFHIR4_2_0_000 supplementalDataElementsFHIR4_2_0_000,
    MATGlobalCommonFunctionsFHIR4_6_1_000 matGlobalCommonFunctionsFHIR4_6_1_000)
{

    [CqlDeclaration("Bicarbonate lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139")]
	public  CqlValueSet Bicarbonate_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", default);

    [CqlDeclaration("Body temperature")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152")]
	public  CqlValueSet Body_temperature(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", default);

    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
	public  CqlValueSet Creatinine_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public  CqlValueSet Emergency_Department_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public  CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public  CqlValueSet Ethnicity(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", default);

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
	public  CqlValueSet Hematocrit_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", default);

    [CqlDeclaration("Medicare payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
	public  CqlValueSet Medicare_payer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", default);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public  CqlValueSet Observation_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public  CqlValueSet ONC_Administrative_Sex(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", default);

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public  CqlValueSet Payer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", default);

    [CqlDeclaration("Platelet count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127")]
	public  CqlValueSet Platelet_count_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", default);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public  CqlValueSet Race(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", default);

    [CqlDeclaration("Sodium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119")]
	public  CqlValueSet Sodium_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", default);

    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
	public  CqlValueSet White_blood_cells_count_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", default);

    [CqlDeclaration("Birth date")]
	public  CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Heart rate")]
	public  CqlCode Heart_rate(CqlContext context) => 
		new CqlCode("8867-4", "http://loinc.org", default, default);

    [CqlDeclaration("Oxygen saturation in Arterial blood by Pulse oximetry")]
	public  CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext context) => 
		new CqlCode("59408-5", "http://loinc.org", default, default);

    [CqlDeclaration("Systolic blood pressure")]
	public  CqlCode Systolic_blood_pressure(CqlContext context) => 
		new CqlCode("8480-6", "http://loinc.org", default, default);

    [CqlDeclaration("LOINC:2.69")]
	public  CqlCode[] LOINC_2_69(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
			new CqlCode("8867-4", "http://loinc.org", default, default),
			new CqlCode("59408-5", "http://loinc.org", default, default),
			new CqlCode("8480-6", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public  IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		IEnumerable<Coding> a_ = supplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public  IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = supplementalDataElementsFHIR4_2_0_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public  IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		IEnumerable<Coding> a_ = supplementalDataElementsFHIR4_2_0_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public  CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = supplementalDataElementsFHIR4_2_0_000.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("LengthInDays")]
	public  int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
	{
		CqlDateTime a_ = context.Operators.Start(Value);
		CqlDateTime b_ = context.Operators.End(Value);
		int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

    [CqlDeclaration("Inpatient Encounters")]
	public  IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
	{
		CqlValueSet a_ = this.Encounter_Inpatient(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Medicare_payer(context);
		IEnumerable<Coverage> d_ = context.Operators.RetrieveByValueSet<Coverage>(c_, default);
		IEnumerable<ValueTuple<Encounter, Coverage>> e_ = context.Operators.CrossJoin<Encounter, Coverage>(b_, d_);
		(Encounter InpatientEncounter, Coverage Payer)? f_(ValueTuple<Encounter, Coverage> _valueTuple)
		{
			(Encounter InpatientEncounter, Coverage Payer)? l_ = (_valueTuple.Item1, _valueTuple.Item2);

			return l_;
		};
		IEnumerable<(Encounter InpatientEncounter, Coverage Payer)?> g_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (Encounter InpatientEncounter, Coverage Payer)?>(e_, f_);
		bool? h_((Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
		{
			Code<Encounter.EncounterStatus> m_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
			string n_ = fhirHelpers_4_0_001.ToString(context, m_);
			bool? o_ = context.Operators.Equal(n_, "finished");
			CqlInterval<CqlDateTime> p_ = matGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
			int? q_ = this.LengthInDays(context, p_);
			bool? r_ = context.Operators.Less(q_, 365);
			bool? s_ = context.Operators.And(o_, r_);
			Period t_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
			CqlInterval<CqlDateTime> u_ = fhirHelpers_4_0_001.ToInterval(context, t_);
			CqlDateTime v_ = context.Operators.End(u_);
			CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
			bool? x_ = context.Operators.In<CqlDateTime>(v_, w_, "day");
			bool? y_ = context.Operators.And(s_, x_);
			Patient z_ = this.Patient(context);
			Date aa_ = z_?.BirthDateElement;
			string ab_ = aa_?.Value;
			CqlDate ac_ = context.Operators.ConvertStringToDate(ab_);
			CqlInterval<CqlDateTime> ae_ = fhirHelpers_4_0_001.ToInterval(context, t_);
			CqlDateTime af_ = context.Operators.Start(ae_);
			CqlDate ag_ = context.Operators.DateFrom(af_);
			int? ah_ = context.Operators.CalculateAgeAt(ac_, ag_, "year");
			CqlInterval<int?> ai_ = context.Operators.Interval(65, 94, true, true);
			bool? aj_ = context.Operators.In<int?>(ah_, ai_, default);
			bool? ak_ = context.Operators.And(y_, aj_);

			return ak_;
		};
		IEnumerable<(Encounter InpatientEncounter, Coverage Payer)?> i_ = context.Operators.Where<(Encounter InpatientEncounter, Coverage Payer)?>(g_, h_);
		Encounter j_((Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) => 
			tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
		IEnumerable<Encounter> k_ = context.Operators.Select<(Encounter InpatientEncounter, Coverage Payer)?, Encounter>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Initial Population")]
	public  IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

		return a_;
	}

    [CqlDeclaration("FirstPhysicalExamWithEncounterId")]
	public  IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
		string b_(Encounter Encounter)
		{
			string d_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
			string e_ = context.Operators.Concatenate(d_ ?? "", ",");
			Id f_ = Encounter?.IdElement;
			string g_ = fhirHelpers_4_0_001.ToString(context, f_);
			string h_ = context.Operators.Concatenate(e_ ?? "", g_ ?? "");
			string i_ = context.Operators.Concatenate(h_ ?? "", " , ");
			bool? j_(Observation Exam)
			{
				DataType ad_ = Exam?.Effective;
				CqlInterval<CqlDateTime> ae_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, ad_);
				CqlDateTime af_ = context.Operators.Start(ae_);
				bool? ag_ = context.Operators.Not((bool?)(af_ is null));
				CqlInterval<CqlDateTime> ai_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, ad_);
				CqlDateTime aj_ = context.Operators.Start(ai_);
				Period ak_ = Encounter?.Period;
				CqlInterval<CqlDateTime> al_ = fhirHelpers_4_0_001.ToInterval(context, ak_);
				CqlDateTime am_ = context.Operators.Start(al_);
				CqlQuantity an_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ao_ = context.Operators.Subtract(am_, an_);
				CqlInterval<CqlDateTime> aq_ = fhirHelpers_4_0_001.ToInterval(context, ak_);
				CqlDateTime ar_ = context.Operators.Start(aq_);
				CqlQuantity as_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime at_ = context.Operators.Add(ar_, as_);
				CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ao_, at_, true, true);
				bool? av_ = context.Operators.In<CqlDateTime>(aj_, au_, default);
				bool? aw_ = context.Operators.And(ag_, av_);
				Code<ObservationStatus> ax_ = Exam?.StatusElement;
				string ay_ = fhirHelpers_4_0_001.ToString(context, ax_);
				string[] az_ = [
					"final",
					"amended",
					"preliminary",
				];
				bool? ba_ = context.Operators.In<string>(ay_, az_ as IEnumerable<string>);
				bool? bb_ = context.Operators.And(aw_, ba_);
				DataType bc_ = Exam?.Value;
				bool? bd_ = context.Operators.Not((bool?)(bc_ is null));
				bool? be_ = context.Operators.And(bb_, bd_);

				return be_;
			};
			IEnumerable<Observation> k_ = context.Operators.Where<Observation>(ExamList, j_);
			object l_(Observation @this)
			{
				DataType bf_ = @this?.Effective;
				CqlInterval<CqlDateTime> bg_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, bf_);
				CqlDateTime bh_ = context.Operators.Start(bg_);

				return bh_;
			};
			IEnumerable<Observation> m_ = context.Operators.SortBy<Observation>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
			Observation n_ = context.Operators.First<Observation>(m_);
			DataType o_ = n_?.Value;
			CqlQuantity p_ = fhirHelpers_4_0_001.ToQuantity(context, o_ as Quantity);
			string q_ = context.Operators.ConvertQuantityToString(p_);
			string r_ = context.Operators.Concatenate(i_ ?? "", q_ ?? "");
			string s_ = context.Operators.Concatenate(r_ ?? "", ",");
			bool? t_(Observation Exam)
			{
				DataType bi_ = Exam?.Effective;
				CqlInterval<CqlDateTime> bj_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, bi_);
				CqlDateTime bk_ = context.Operators.Start(bj_);
				bool? bl_ = context.Operators.Not((bool?)(bk_ is null));
				CqlInterval<CqlDateTime> bn_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, bi_);
				CqlDateTime bo_ = context.Operators.Start(bn_);
				Period bp_ = Encounter?.Period;
				CqlInterval<CqlDateTime> bq_ = fhirHelpers_4_0_001.ToInterval(context, bp_);
				CqlDateTime br_ = context.Operators.Start(bq_);
				CqlQuantity bs_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bt_ = context.Operators.Subtract(br_, bs_);
				CqlInterval<CqlDateTime> bv_ = fhirHelpers_4_0_001.ToInterval(context, bp_);
				CqlDateTime bw_ = context.Operators.Start(bv_);
				CqlQuantity bx_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime by_ = context.Operators.Add(bw_, bx_);
				CqlInterval<CqlDateTime> bz_ = context.Operators.Interval(bt_, by_, true, true);
				bool? ca_ = context.Operators.In<CqlDateTime>(bo_, bz_, default);
				bool? cb_ = context.Operators.And(bl_, ca_);
				Code<ObservationStatus> cc_ = Exam?.StatusElement;
				string cd_ = fhirHelpers_4_0_001.ToString(context, cc_);
				string[] ce_ = [
					"final",
					"amended",
					"preliminary",
				];
				bool? cf_ = context.Operators.In<string>(cd_, ce_ as IEnumerable<string>);
				bool? cg_ = context.Operators.And(cb_, cf_);
				DataType ch_ = Exam?.Value;
				bool? ci_ = context.Operators.Not((bool?)(ch_ is null));
				bool? cj_ = context.Operators.And(cg_, ci_);

				return cj_;
			};
			IEnumerable<Observation> u_ = context.Operators.Where<Observation>(ExamList, t_);
			object v_(Observation @this)
			{
				DataType ck_ = @this?.Effective;
				CqlInterval<CqlDateTime> cl_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, ck_);
				CqlDateTime cm_ = context.Operators.Start(cl_);

				return cm_;
			};
			IEnumerable<Observation> w_ = context.Operators.SortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
			Observation x_ = context.Operators.First<Observation>(w_);
			DataType y_ = x_?.Effective;
			CqlInterval<CqlDateTime> z_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, y_);
			CqlDateTime aa_ = context.Operators.Start(z_);
			string ab_ = context.Operators.ConvertDateTimeToString(aa_);
			string ac_ = context.Operators.Concatenate(s_ ?? "", ab_ ?? "");

			return ac_;
		};
		IEnumerable<string> c_ = context.Operators.Select<Encounter, string>(a_, b_);

		return c_;
	}

    [CqlDeclaration("FirstLabTestWithEncounterId")]
	public  IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
		string b_(Encounter Encounter)
		{
			string d_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
			string e_ = context.Operators.Concatenate(d_ ?? "", ",");
			Id f_ = Encounter?.IdElement;
			string g_ = fhirHelpers_4_0_001.ToString(context, f_);
			string h_ = context.Operators.Concatenate(e_ ?? "", g_ ?? "");
			string i_ = context.Operators.Concatenate(h_ ?? "", ",");
			bool? j_(Observation Lab)
			{
				Instant ac_ = Lab?.IssuedElement;
				bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
				CqlDateTime af_ = fhirHelpers_4_0_001.ToDateTime(context, ac_);
				Period ag_ = Encounter?.Period;
				CqlInterval<CqlDateTime> ah_ = fhirHelpers_4_0_001.ToInterval(context, ag_);
				CqlDateTime ai_ = context.Operators.Start(ah_);
				CqlQuantity aj_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ak_ = context.Operators.Subtract(ai_, aj_);
				CqlInterval<CqlDateTime> am_ = fhirHelpers_4_0_001.ToInterval(context, ag_);
				CqlDateTime an_ = context.Operators.Start(am_);
				CqlDateTime ap_ = context.Operators.Add(an_, aj_);
				CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(ak_, ap_, true, true);
				bool? ar_ = context.Operators.In<CqlDateTime>(af_, aq_, default);
				bool? as_ = context.Operators.And(ad_, ar_);
				Code<ObservationStatus> at_ = Lab?.StatusElement;
				string au_ = fhirHelpers_4_0_001.ToString(context, at_);
				string[] av_ = [
					"final",
					"amended",
					"preliminary",
				];
				bool? aw_ = context.Operators.In<string>(au_, av_ as IEnumerable<string>);
				bool? ax_ = context.Operators.And(as_, aw_);
				DataType ay_ = Lab?.Value;
				bool? az_ = context.Operators.Not((bool?)(ay_ is null));
				bool? ba_ = context.Operators.And(ax_, az_);

				return ba_;
			};
			IEnumerable<Observation> k_ = context.Operators.Where<Observation>(LabList, j_);
			object l_(Observation @this)
			{
				Instant bb_ = @this?.IssuedElement;

				return bb_;
			};
			IEnumerable<Observation> m_ = context.Operators.SortBy<Observation>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
			Observation n_ = context.Operators.First<Observation>(m_);
			DataType o_ = n_?.Value;
			CqlQuantity p_ = fhirHelpers_4_0_001.ToQuantity(context, o_ as Quantity);
			string q_ = context.Operators.ConvertQuantityToString(p_);
			string r_ = context.Operators.Concatenate(i_ ?? "", q_ ?? "");
			string s_ = context.Operators.Concatenate(r_ ?? "", ",");
			bool? t_(Observation Lab)
			{
				Instant bc_ = Lab?.IssuedElement;
				bool? bd_ = context.Operators.Not((bool?)(bc_ is null));
				CqlDateTime bf_ = fhirHelpers_4_0_001.ToDateTime(context, bc_);
				Period bg_ = Encounter?.Period;
				CqlInterval<CqlDateTime> bh_ = fhirHelpers_4_0_001.ToInterval(context, bg_);
				CqlDateTime bi_ = context.Operators.Start(bh_);
				CqlQuantity bj_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bk_ = context.Operators.Subtract(bi_, bj_);
				CqlInterval<CqlDateTime> bm_ = fhirHelpers_4_0_001.ToInterval(context, bg_);
				CqlDateTime bn_ = context.Operators.Start(bm_);
				CqlDateTime bp_ = context.Operators.Add(bn_, bj_);
				CqlInterval<CqlDateTime> bq_ = context.Operators.Interval(bk_, bp_, true, true);
				bool? br_ = context.Operators.In<CqlDateTime>(bf_, bq_, default);
				bool? bs_ = context.Operators.And(bd_, br_);
				Code<ObservationStatus> bt_ = Lab?.StatusElement;
				string bu_ = fhirHelpers_4_0_001.ToString(context, bt_);
				string[] bv_ = [
					"final",
					"amended",
					"preliminary",
				];
				bool? bw_ = context.Operators.In<string>(bu_, bv_ as IEnumerable<string>);
				bool? bx_ = context.Operators.And(bs_, bw_);
				DataType by_ = Lab?.Value;
				bool? bz_ = context.Operators.Not((bool?)(by_ is null));
				bool? ca_ = context.Operators.And(bx_, bz_);

				return ca_;
			};
			IEnumerable<Observation> u_ = context.Operators.Where<Observation>(LabList, t_);
			object v_(Observation @this)
			{
				Instant cb_ = @this?.IssuedElement;

				return cb_;
			};
			IEnumerable<Observation> w_ = context.Operators.SortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
			Observation x_ = context.Operators.First<Observation>(w_);
			Instant y_ = x_?.IssuedElement;
			CqlDateTime z_ = fhirHelpers_4_0_001.ToDateTime(context, y_);
			string aa_ = context.Operators.ConvertDateTimeToString(z_);
			string ab_ = context.Operators.Concatenate(s_ ?? "", aa_ ?? "");

			return ab_;
		};
		IEnumerable<string> c_ = context.Operators.Select<Encounter, string>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Results")]
	public  IEnumerable<string> Results(CqlContext context)
	{
		CqlCode a_ = this.Heart_rate(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		IEnumerable<string> d_ = this.FirstPhysicalExamWithEncounterId(context, c_, "FirstHeartRate");
		CqlCode e_ = this.Systolic_blood_pressure(context);
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, default);
		IEnumerable<string> h_ = this.FirstPhysicalExamWithEncounterId(context, g_, "FirstSystolicBP");
		CqlValueSet i_ = this.Body_temperature(context);
		IEnumerable<Observation> j_ = context.Operators.RetrieveByValueSet<Observation>(i_, default);
		IEnumerable<string> k_ = this.FirstPhysicalExamWithEncounterId(context, j_, "FirstTemperature");
		CqlCode l_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
		IEnumerable<CqlCode> m_ = context.Operators.ToList<CqlCode>(l_);
		IEnumerable<Observation> n_ = context.Operators.RetrieveByCodes<Observation>(m_, default);
		IEnumerable<string> o_ = this.FirstPhysicalExamWithEncounterId(context, n_, "FirstO2Saturation");
		CqlValueSet p_ = this.Hematocrit_lab_test(context);
		IEnumerable<Observation> q_ = context.Operators.RetrieveByValueSet<Observation>(p_, default);
		IEnumerable<string> r_ = this.FirstLabTestWithEncounterId(context, q_, "FirstHematocrit");
		CqlValueSet s_ = this.Platelet_count_lab_test(context);
		IEnumerable<Observation> t_ = context.Operators.RetrieveByValueSet<Observation>(s_, default);
		IEnumerable<string> u_ = this.FirstLabTestWithEncounterId(context, t_, "FirstPlateletCount");
		CqlValueSet v_ = this.White_blood_cells_count_lab_test(context);
		IEnumerable<Observation> w_ = context.Operators.RetrieveByValueSet<Observation>(v_, default);
		IEnumerable<string> x_ = this.FirstLabTestWithEncounterId(context, w_, "FirstWhiteBloodCell");
		CqlValueSet y_ = this.Sodium_lab_test(context);
		IEnumerable<Observation> z_ = context.Operators.RetrieveByValueSet<Observation>(y_, default);
		IEnumerable<string> aa_ = this.FirstLabTestWithEncounterId(context, z_, "FirstSodium");
		CqlValueSet ab_ = this.Bicarbonate_lab_test(context);
		IEnumerable<Observation> ac_ = context.Operators.RetrieveByValueSet<Observation>(ab_, default);
		IEnumerable<string> ad_ = this.FirstLabTestWithEncounterId(context, ac_, "FirstBicarbonate");
		CqlValueSet ae_ = this.Creatinine_lab_test(context);
		IEnumerable<Observation> af_ = context.Operators.RetrieveByValueSet<Observation>(ae_, default);
		IEnumerable<string> ag_ = this.FirstLabTestWithEncounterId(context, af_, "FirstCreatinine");
		IEnumerable<string>[] ah_ = [
			d_,
			h_,
			k_,
			o_,
			r_,
			u_,
			x_,
			aa_,
			ad_,
			ag_,
		];
		IEnumerable<string> ai_ = context.Operators.Flatten<string>(ah_ as IEnumerable<IEnumerable<string>>);

		return ai_;
	}

    [CqlDeclaration("CalendarAgeInYearsAt")]
	public  int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
	{
		CqlDate a_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
		CqlDate b_ = context.Operators.ConvertDateTimeToDate(AsOf);
		int? c_ = context.Operators.DurationBetween(a_, b_, "year");

		return c_;
	}

    [CqlDeclaration("ToDate")]
	public  CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
	{
		int? a_ = context.Operators.DateTimeComponentFrom(Value, "year");
		int? b_ = context.Operators.DateTimeComponentFrom(Value, "month");
		int? c_ = context.Operators.DateTimeComponentFrom(Value, "day");
		decimal? d_ = context.Operators.TimezoneOffsetFrom(Value);
		CqlDateTime e_ = context.Operators.DateTime(a_, b_, c_, 0, 0, 0, 0, d_);

		return e_;
	}

    [CqlDeclaration("LengthOfStay")]
	public  int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
	{
		CqlDateTime a_ = context.Operators.Start(Stay);
		CqlDateTime b_ = context.Operators.End(Stay);
		int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

    [CqlDeclaration("HospitalizationWithObservation")]
	public  CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
	{
		Encounter[] a_ = [
			TheEncounter,
		];
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Emergency_Department_Visit(context);
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, default);
			bool? g_(Encounter LastED)
			{
				Period af_ = LastED?.Period;
				CqlInterval<CqlDateTime> ag_ = fhirHelpers_4_0_001.ToInterval(context, af_);
				CqlDateTime ah_ = context.Operators.End(ag_);
				CqlValueSet ai_ = this.Observation_Services(context);
				IEnumerable<Encounter> aj_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, default);
				bool? ak_(Encounter LastObs)
				{
					Period cb_ = LastObs?.Period;
					CqlInterval<CqlDateTime> cc_ = fhirHelpers_4_0_001.ToInterval(context, cb_);
					CqlDateTime cd_ = context.Operators.End(cc_);
					Period ce_ = Visit?.Period;
					CqlInterval<CqlDateTime> cf_ = fhirHelpers_4_0_001.ToInterval(context, ce_);
					CqlDateTime cg_ = context.Operators.Start(cf_);
					CqlQuantity ch_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ci_ = context.Operators.Subtract(cg_, ch_);
					CqlInterval<CqlDateTime> ck_ = fhirHelpers_4_0_001.ToInterval(context, ce_);
					CqlDateTime cl_ = context.Operators.Start(ck_);
					CqlInterval<CqlDateTime> cm_ = context.Operators.Interval(ci_, cl_, true, true);
					bool? cn_ = context.Operators.In<CqlDateTime>(cd_, cm_, default);
					CqlInterval<CqlDateTime> cp_ = fhirHelpers_4_0_001.ToInterval(context, ce_);
					CqlDateTime cq_ = context.Operators.Start(cp_);
					bool? cr_ = context.Operators.Not((bool?)(cq_ is null));
					bool? cs_ = context.Operators.And(cn_, cr_);

					return cs_;
				};
				IEnumerable<Encounter> al_ = context.Operators.Where<Encounter>(aj_, ak_);
				object am_(Encounter @this)
				{
					Period ct_ = @this?.Period;
					CqlInterval<CqlDateTime> cu_ = fhirHelpers_4_0_001.ToInterval(context, ct_);
					CqlDateTime cv_ = context.Operators.End(cu_);

					return cv_;
				};
				IEnumerable<Encounter> an_ = context.Operators.SortBy<Encounter>(al_, am_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ao_ = context.Operators.Last<Encounter>(an_);
				Period ap_ = ao_?.Period;
				CqlInterval<CqlDateTime> aq_ = fhirHelpers_4_0_001.ToInterval(context, ap_);
				CqlDateTime ar_ = context.Operators.Start(aq_);
				Period as_ = Visit?.Period;
				CqlInterval<CqlDateTime> at_ = fhirHelpers_4_0_001.ToInterval(context, as_);
				CqlDateTime au_ = context.Operators.Start(at_);
				CqlQuantity av_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime aw_ = context.Operators.Subtract(ar_ ?? au_, av_);
				IEnumerable<Encounter> ay_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, default);
				bool? az_(Encounter LastObs)
				{
					Period cw_ = LastObs?.Period;
					CqlInterval<CqlDateTime> cx_ = fhirHelpers_4_0_001.ToInterval(context, cw_);
					CqlDateTime cy_ = context.Operators.End(cx_);
					Period cz_ = Visit?.Period;
					CqlInterval<CqlDateTime> da_ = fhirHelpers_4_0_001.ToInterval(context, cz_);
					CqlDateTime db_ = context.Operators.Start(da_);
					CqlQuantity dc_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dd_ = context.Operators.Subtract(db_, dc_);
					CqlInterval<CqlDateTime> df_ = fhirHelpers_4_0_001.ToInterval(context, cz_);
					CqlDateTime dg_ = context.Operators.Start(df_);
					CqlInterval<CqlDateTime> dh_ = context.Operators.Interval(dd_, dg_, true, true);
					bool? di_ = context.Operators.In<CqlDateTime>(cy_, dh_, default);
					CqlInterval<CqlDateTime> dk_ = fhirHelpers_4_0_001.ToInterval(context, cz_);
					CqlDateTime dl_ = context.Operators.Start(dk_);
					bool? dm_ = context.Operators.Not((bool?)(dl_ is null));
					bool? dn_ = context.Operators.And(di_, dm_);

					return dn_;
				};
				IEnumerable<Encounter> ba_ = context.Operators.Where<Encounter>(ay_, az_);
				object bb_(Encounter @this)
				{
					Period do_ = @this?.Period;
					CqlInterval<CqlDateTime> dp_ = fhirHelpers_4_0_001.ToInterval(context, do_);
					CqlDateTime dq_ = context.Operators.End(dp_);

					return dq_;
				};
				IEnumerable<Encounter> bc_ = context.Operators.SortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bd_ = context.Operators.Last<Encounter>(bc_);
				Period be_ = bd_?.Period;
				CqlInterval<CqlDateTime> bf_ = fhirHelpers_4_0_001.ToInterval(context, be_);
				CqlDateTime bg_ = context.Operators.Start(bf_);
				CqlInterval<CqlDateTime> bi_ = fhirHelpers_4_0_001.ToInterval(context, as_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlInterval<CqlDateTime> bk_ = context.Operators.Interval(aw_, bg_ ?? bj_, true, true);
				bool? bl_ = context.Operators.In<CqlDateTime>(ah_, bk_, default);
				IEnumerable<Encounter> bn_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, default);
				bool? bo_(Encounter LastObs)
				{
					Period dr_ = LastObs?.Period;
					CqlInterval<CqlDateTime> ds_ = fhirHelpers_4_0_001.ToInterval(context, dr_);
					CqlDateTime dt_ = context.Operators.End(ds_);
					Period du_ = Visit?.Period;
					CqlInterval<CqlDateTime> dv_ = fhirHelpers_4_0_001.ToInterval(context, du_);
					CqlDateTime dw_ = context.Operators.Start(dv_);
					CqlQuantity dx_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dy_ = context.Operators.Subtract(dw_, dx_);
					CqlInterval<CqlDateTime> ea_ = fhirHelpers_4_0_001.ToInterval(context, du_);
					CqlDateTime eb_ = context.Operators.Start(ea_);
					CqlInterval<CqlDateTime> ec_ = context.Operators.Interval(dy_, eb_, true, true);
					bool? ed_ = context.Operators.In<CqlDateTime>(dt_, ec_, default);
					CqlInterval<CqlDateTime> ef_ = fhirHelpers_4_0_001.ToInterval(context, du_);
					CqlDateTime eg_ = context.Operators.Start(ef_);
					bool? eh_ = context.Operators.Not((bool?)(eg_ is null));
					bool? ei_ = context.Operators.And(ed_, eh_);

					return ei_;
				};
				IEnumerable<Encounter> bp_ = context.Operators.Where<Encounter>(bn_, bo_);
				object bq_(Encounter @this)
				{
					Period ej_ = @this?.Period;
					CqlInterval<CqlDateTime> ek_ = fhirHelpers_4_0_001.ToInterval(context, ej_);
					CqlDateTime el_ = context.Operators.End(ek_);

					return el_;
				};
				IEnumerable<Encounter> br_ = context.Operators.SortBy<Encounter>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bs_ = context.Operators.Last<Encounter>(br_);
				Period bt_ = bs_?.Period;
				CqlInterval<CqlDateTime> bu_ = fhirHelpers_4_0_001.ToInterval(context, bt_);
				CqlDateTime bv_ = context.Operators.Start(bu_);
				CqlInterval<CqlDateTime> bx_ = fhirHelpers_4_0_001.ToInterval(context, as_);
				CqlDateTime by_ = context.Operators.Start(bx_);
				bool? bz_ = context.Operators.Not((bool?)((bv_ ?? by_) is null));
				bool? ca_ = context.Operators.And(bl_, bz_);

				return ca_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				Period em_ = @this?.Period;
				CqlInterval<CqlDateTime> en_ = fhirHelpers_4_0_001.ToInterval(context, em_);
				CqlDateTime eo_ = context.Operators.End(en_);

				return eo_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			Period l_ = k_?.Period;
			CqlInterval<CqlDateTime> m_ = fhirHelpers_4_0_001.ToInterval(context, l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlValueSet o_ = this.Observation_Services(context);
			IEnumerable<Encounter> p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, default);
			bool? q_(Encounter LastObs)
			{
				Period ep_ = LastObs?.Period;
				CqlInterval<CqlDateTime> eq_ = fhirHelpers_4_0_001.ToInterval(context, ep_);
				CqlDateTime er_ = context.Operators.End(eq_);
				Period es_ = Visit?.Period;
				CqlInterval<CqlDateTime> et_ = fhirHelpers_4_0_001.ToInterval(context, es_);
				CqlDateTime eu_ = context.Operators.Start(et_);
				CqlQuantity ev_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ew_ = context.Operators.Subtract(eu_, ev_);
				CqlInterval<CqlDateTime> ey_ = fhirHelpers_4_0_001.ToInterval(context, es_);
				CqlDateTime ez_ = context.Operators.Start(ey_);
				CqlInterval<CqlDateTime> fa_ = context.Operators.Interval(ew_, ez_, true, true);
				bool? fb_ = context.Operators.In<CqlDateTime>(er_, fa_, default);
				CqlInterval<CqlDateTime> fd_ = fhirHelpers_4_0_001.ToInterval(context, es_);
				CqlDateTime fe_ = context.Operators.Start(fd_);
				bool? ff_ = context.Operators.Not((bool?)(fe_ is null));
				bool? fg_ = context.Operators.And(fb_, ff_);

				return fg_;
			};
			IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				Period fh_ = @this?.Period;
				CqlInterval<CqlDateTime> fi_ = fhirHelpers_4_0_001.ToInterval(context, fh_);
				CqlDateTime fj_ = context.Operators.End(fi_);

				return fj_;
			};
			IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter u_ = context.Operators.Last<Encounter>(t_);
			Period v_ = u_?.Period;
			CqlInterval<CqlDateTime> w_ = fhirHelpers_4_0_001.ToInterval(context, v_);
			CqlDateTime x_ = context.Operators.Start(w_);
			Period y_ = Visit?.Period;
			CqlInterval<CqlDateTime> z_ = fhirHelpers_4_0_001.ToInterval(context, y_);
			CqlDateTime aa_ = context.Operators.Start(z_);
			CqlInterval<CqlDateTime> ac_ = fhirHelpers_4_0_001.ToInterval(context, y_);
			CqlDateTime ad_ = context.Operators.End(ac_);
			CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ad_, true, true);

			return ae_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
	public  int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
	{
		CqlInterval<CqlDateTime> a_ = this.HospitalizationWithObservation(context, Encounter);
		int? b_ = this.LengthInDays(context, a_);

		return b_;
	}

}
