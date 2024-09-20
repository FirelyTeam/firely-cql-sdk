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
public static partial class HybridHospitalWideMortalityFHIR_0_0_001ServiceCollectionExtensions
{
    public static IServiceCollection AddHybridHospitalWideMortalityFHIR_0_0_001(this IServiceCollection services)
    {
        services.TryAddSingleton<HybridHospitalWideMortalityFHIR_0_0_001>(sp =>
        {
            System.IO.File.AppendAllLines("C:\\temp\\library.txt", ["HybridHospitalWideMortalityFHIR_0_0_001"]);
            return ActivatorUtilities.CreateInstance<HybridHospitalWideMortalityFHIR_0_0_001>(sp);
        });
        services.AddCQMCommon_2_0_000();
        services.AddFHIRHelpers_4_3_000();
        services.AddSupplementalDataElements_3_4_000();
        services.AddQICoreCommon_2_0_000();
        return services;
    }
}

partial class HybridHospitalWideMortalityFHIR_0_0_001 : ICqlLibrary
{
    public static void AddLibraryService(IServiceCollection services) =>
        services.AddHybridHospitalWideMortalityFHIR_0_0_001();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("HybridHospitalWideMortalityFHIR", "0.0.001")]
public partial class HybridHospitalWideMortalityFHIR_0_0_001(
    CQMCommon_2_0_000 cqmCommon_2_0_000,
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000)
{

    [CqlDeclaration("Bicarbonate lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139")]
	public CqlValueSet Bicarbonate_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", default);

    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
	public CqlValueSet Creatinine_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
	public CqlValueSet Hematocrit_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", default);

    [CqlDeclaration("Medicare Advantage payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12")]
	public CqlValueSet Medicare_Advantage_payer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12", default);

    [CqlDeclaration("Medicare FFS payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
	public CqlValueSet Medicare_FFS_payer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", default);

    [CqlDeclaration("Oxygen Saturation by Pulse Oximetry")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151")]
	public CqlValueSet Oxygen_Saturation_by_Pulse_Oximetry(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151", default);

    [CqlDeclaration("Platelet count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127")]
	public CqlValueSet Platelet_count_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", default);

    [CqlDeclaration("Sodium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119")]
	public CqlValueSet Sodium_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", default);

    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
	public CqlValueSet White_blood_cells_count_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", default);

    [CqlDeclaration("Oxygen saturation in Arterial blood")]
	public CqlCode Oxygen_saturation_in_Arterial_blood(CqlContext context) => 
		new CqlCode("2708-6", "http://loinc.org", default, default);

    [CqlDeclaration("Oxygen saturation in Arterial blood by Pulse oximetry")]
	public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext context) => 
		new CqlCode("59408-5", "http://loinc.org", default, default);

    [CqlDeclaration("Systolic blood pressure")]
	public CqlCode Systolic_blood_pressure(CqlContext context) => 
		new CqlCode("8480-6", "http://loinc.org", default, default);

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("2708-6", "http://loinc.org", default, default),
			new CqlCode("59408-5", "http://loinc.org", default, default),
			new CqlCode("8480-6", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("Source of Payment Typology")]
	public CqlCode[] Source_of_Payment_Typology(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HybridHospitalWideMortalityFHIR-0.0.001", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Inpatient Encounters")]
	public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
	{
		CqlValueSet a_ = this.Encounter_Inpatient(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		IEnumerable<Encounter> c_(Encounter InpatientEncounter)
		{
			CqlValueSet e_ = this.Medicare_FFS_payer(context);
			IEnumerable<Coverage> f_ = context.Operators.RetrieveByValueSet<Coverage>(e_, default);
			CqlValueSet g_ = this.Medicare_Advantage_payer(context);
			IEnumerable<Coverage> h_ = context.Operators.RetrieveByValueSet<Coverage>(g_, default);
			IEnumerable<Coverage> i_ = context.Operators.Union<Coverage>(f_, h_);
			bool? j_(Coverage MedicarePayer)
			{
				CqlInterval<CqlDateTime> n_ = cqmCommon_2_0_000.hospitalizationWithObservationAndOutpatientSurgeryService(context, InpatientEncounter);
				int? o_ = cqmCommon_2_0_000.lengthInDays(context, n_);
				bool? p_ = context.Operators.Less(o_, 365);
				Code<Encounter.EncounterStatus> q_ = InpatientEncounter?.StatusElement;
				Encounter.EncounterStatus? r_ = q_?.Value;
				Code<Encounter.EncounterStatus> s_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(r_);
				bool? t_ = context.Operators.Equal(s_, "finished");
				bool? u_ = context.Operators.And(p_, t_);
				Patient v_ = this.Patient(context);
				Date w_ = v_?.BirthDateElement;
				string x_ = w_?.Value;
				CqlDate y_ = context.Operators.ConvertStringToDate(x_);
				Period z_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> aa_ = fhirHelpers_4_3_000.ToInterval(context, z_);
				CqlDateTime ab_ = context.Operators.Start(aa_);
				CqlDate ac_ = context.Operators.DateFrom(ab_);
				int? ad_ = context.Operators.CalculateAgeAt(y_, ac_, "year");
				CqlInterval<int?> ae_ = context.Operators.Interval(65, 94, true, true);
				bool? af_ = context.Operators.In<int?>(ad_, ae_, default);
				bool? ag_ = context.Operators.And(u_, af_);
				CqlInterval<CqlDateTime> ai_ = fhirHelpers_4_3_000.ToInterval(context, z_);
				CqlDateTime aj_ = context.Operators.End(ai_);
				CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
				bool? al_ = context.Operators.In<CqlDateTime>(aj_, ak_, "day");
				bool? am_ = context.Operators.And(ag_, al_);

				return am_;
			};
			IEnumerable<Coverage> k_ = context.Operators.Where<Coverage>(i_, j_);
			Encounter l_(Coverage MedicarePayer) => 
				InpatientEncounter;
			IEnumerable<Encounter> m_ = context.Operators.Select<Coverage, Encounter>(k_, l_);

			return m_;
		};
		IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

		return a_;
	}

    [CqlDeclaration("Encounter with First Body Temperature")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> Encounter_with_First_Body_Temperature(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
		(string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			IEnumerable<Observation> f_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? g_(Observation temperature)
			{
				DataType x_ = temperature?.Effective;
				object y_ = fhirHelpers_4_3_000.ToValue(context, x_);
				CqlDateTime z_ = qiCoreCommon_2_0_000.earliest(context, y_);
				Period aa_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> ab_ = fhirHelpers_4_3_000.ToInterval(context, aa_);
				CqlDateTime ac_ = context.Operators.Start(ab_);
				CqlQuantity ad_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
				CqlInterval<CqlDateTime> ag_ = fhirHelpers_4_3_000.ToInterval(context, aa_);
				CqlDateTime ah_ = context.Operators.Start(ag_);
				CqlQuantity ai_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime aj_ = context.Operators.Add(ah_, ai_);
				CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(ae_, aj_, true, true);
				bool? al_ = context.Operators.In<CqlDateTime>(z_, ak_, default);
				Code<ObservationStatus> am_ = temperature?.StatusElement;
				ObservationStatus? an_ = am_?.Value;
				string ao_ = context.Operators.Convert<string>(an_);
				string[] ap_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? aq_ = context.Operators.In<string>(ao_, ap_ as IEnumerable<string>);
				bool? ar_ = context.Operators.And(al_, aq_);
				DataType as_ = temperature?.Value;
				CqlQuantity at_ = fhirHelpers_4_3_000.ToQuantity(context, as_ as Quantity);
				bool? au_ = context.Operators.Not((bool?)(at_ is null));
				bool? av_ = context.Operators.And(ar_, au_);

				return av_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				DataType aw_ = @this?.Effective;
				object ax_ = fhirHelpers_4_3_000.ToValue(context, aw_);
				CqlDateTime ay_ = qiCoreCommon_2_0_000.earliest(context, ax_);

				return ay_;
			};
			IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Observation k_ = context.Operators.First<Observation>(j_);
			DataType l_ = k_?.Value;
			CqlQuantity m_ = fhirHelpers_4_3_000.ToQuantity(context, l_ as Quantity);
			bool? o_(Observation temperature)
			{
				DataType az_ = temperature?.Effective;
				object ba_ = fhirHelpers_4_3_000.ToValue(context, az_);
				CqlDateTime bb_ = qiCoreCommon_2_0_000.earliest(context, ba_);
				Period bc_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bd_ = fhirHelpers_4_3_000.ToInterval(context, bc_);
				CqlDateTime be_ = context.Operators.Start(bd_);
				CqlQuantity bf_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bg_ = context.Operators.Subtract(be_, bf_);
				CqlInterval<CqlDateTime> bi_ = fhirHelpers_4_3_000.ToInterval(context, bc_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlQuantity bk_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime bl_ = context.Operators.Add(bj_, bk_);
				CqlInterval<CqlDateTime> bm_ = context.Operators.Interval(bg_, bl_, true, true);
				bool? bn_ = context.Operators.In<CqlDateTime>(bb_, bm_, default);
				Code<ObservationStatus> bo_ = temperature?.StatusElement;
				ObservationStatus? bp_ = bo_?.Value;
				string bq_ = context.Operators.Convert<string>(bp_);
				string[] br_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bs_ = context.Operators.In<string>(bq_, br_ as IEnumerable<string>);
				bool? bt_ = context.Operators.And(bn_, bs_);
				DataType bu_ = temperature?.Value;
				CqlQuantity bv_ = fhirHelpers_4_3_000.ToQuantity(context, bu_ as Quantity);
				bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
				bool? bx_ = context.Operators.And(bt_, bw_);

				return bx_;
			};
			IEnumerable<Observation> p_ = context.Operators.Where<Observation>(f_, o_);
			object q_(Observation @this)
			{
				DataType by_ = @this?.Effective;
				object bz_ = fhirHelpers_4_3_000.ToValue(context, by_);
				CqlDateTime ca_ = qiCoreCommon_2_0_000.earliest(context, bz_);

				return ca_;
			};
			IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
			Observation s_ = context.Operators.First<Observation>(r_);
			DataType t_ = s_?.Effective;
			object u_ = fhirHelpers_4_3_000.ToValue(context, t_);
			CqlDateTime v_ = qiCoreCommon_2_0_000.earliest(context, u_);
			(string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? w_ = (e_, m_ as CqlQuantity, v_);

			return w_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Heart Rate")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> Encounter_with_First_Heart_Rate(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
		(string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			IEnumerable<Observation> f_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? g_(Observation HeartRate)
			{
				DataType x_ = HeartRate?.Effective;
				object y_ = fhirHelpers_4_3_000.ToValue(context, x_);
				CqlDateTime z_ = qiCoreCommon_2_0_000.earliest(context, y_);
				Period aa_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> ab_ = fhirHelpers_4_3_000.ToInterval(context, aa_);
				CqlDateTime ac_ = context.Operators.Start(ab_);
				CqlQuantity ad_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
				CqlInterval<CqlDateTime> ag_ = fhirHelpers_4_3_000.ToInterval(context, aa_);
				CqlDateTime ah_ = context.Operators.Start(ag_);
				CqlQuantity ai_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime aj_ = context.Operators.Add(ah_, ai_);
				CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(ae_, aj_, true, true);
				bool? al_ = context.Operators.In<CqlDateTime>(z_, ak_, default);
				Code<ObservationStatus> am_ = HeartRate?.StatusElement;
				ObservationStatus? an_ = am_?.Value;
				string ao_ = context.Operators.Convert<string>(an_);
				string[] ap_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? aq_ = context.Operators.In<string>(ao_, ap_ as IEnumerable<string>);
				bool? ar_ = context.Operators.And(al_, aq_);
				DataType as_ = HeartRate?.Value;
				CqlQuantity at_ = fhirHelpers_4_3_000.ToQuantity(context, as_ as Quantity);
				bool? au_ = context.Operators.Not((bool?)(at_ is null));
				bool? av_ = context.Operators.And(ar_, au_);

				return av_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				DataType aw_ = @this?.Effective;
				object ax_ = fhirHelpers_4_3_000.ToValue(context, aw_);
				CqlDateTime ay_ = qiCoreCommon_2_0_000.earliest(context, ax_);

				return ay_;
			};
			IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Observation k_ = context.Operators.First<Observation>(j_);
			DataType l_ = k_?.Value;
			CqlQuantity m_ = fhirHelpers_4_3_000.ToQuantity(context, l_ as Quantity);
			bool? o_(Observation HeartRate)
			{
				DataType az_ = HeartRate?.Effective;
				object ba_ = fhirHelpers_4_3_000.ToValue(context, az_);
				CqlDateTime bb_ = qiCoreCommon_2_0_000.earliest(context, ba_);
				Period bc_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bd_ = fhirHelpers_4_3_000.ToInterval(context, bc_);
				CqlDateTime be_ = context.Operators.Start(bd_);
				CqlQuantity bf_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bg_ = context.Operators.Subtract(be_, bf_);
				CqlInterval<CqlDateTime> bi_ = fhirHelpers_4_3_000.ToInterval(context, bc_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlQuantity bk_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime bl_ = context.Operators.Add(bj_, bk_);
				CqlInterval<CqlDateTime> bm_ = context.Operators.Interval(bg_, bl_, true, true);
				bool? bn_ = context.Operators.In<CqlDateTime>(bb_, bm_, default);
				Code<ObservationStatus> bo_ = HeartRate?.StatusElement;
				ObservationStatus? bp_ = bo_?.Value;
				string bq_ = context.Operators.Convert<string>(bp_);
				string[] br_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bs_ = context.Operators.In<string>(bq_, br_ as IEnumerable<string>);
				bool? bt_ = context.Operators.And(bn_, bs_);
				DataType bu_ = HeartRate?.Value;
				CqlQuantity bv_ = fhirHelpers_4_3_000.ToQuantity(context, bu_ as Quantity);
				bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
				bool? bx_ = context.Operators.And(bt_, bw_);

				return bx_;
			};
			IEnumerable<Observation> p_ = context.Operators.Where<Observation>(f_, o_);
			object q_(Observation @this)
			{
				DataType by_ = @this?.Effective;
				object bz_ = fhirHelpers_4_3_000.ToValue(context, by_);
				CqlDateTime ca_ = qiCoreCommon_2_0_000.earliest(context, bz_);

				return ca_;
			};
			IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
			Observation s_ = context.Operators.First<Observation>(r_);
			DataType t_ = s_?.Effective;
			object u_ = fhirHelpers_4_3_000.ToValue(context, t_);
			CqlDateTime v_ = qiCoreCommon_2_0_000.earliest(context, u_);
			(string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? w_ = (e_, m_ as CqlQuantity, v_);

			return w_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Oxygen Saturation")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> Encounter_with_First_Oxygen_Saturation(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
		(string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation O2Saturation)
			{
				object r_()
				{
					bool aq_()
					{
						DataType at_ = O2Saturation?.Effective;
						object au_ = fhirHelpers_4_3_000.ToValue(context, at_);
						bool av_ = au_ is CqlDateTime;

						return av_;
					};
					bool ar_()
					{
						DataType aw_ = O2Saturation?.Effective;
						object ax_ = fhirHelpers_4_3_000.ToValue(context, aw_);
						bool ay_ = ax_ is CqlInterval<CqlDateTime>;

						return ay_;
					};
					bool as_()
					{
						DataType az_ = O2Saturation?.Effective;
						object ba_ = fhirHelpers_4_3_000.ToValue(context, az_);
						bool bb_ = ba_ is CqlDateTime;

						return bb_;
					};
					if (aq_())
					{
						DataType bc_ = O2Saturation?.Effective;
						object bd_ = fhirHelpers_4_3_000.ToValue(context, bc_);

						return (bd_ as CqlDateTime) as object;
					}
					else if (ar_())
					{
						DataType be_ = O2Saturation?.Effective;
						object bf_ = fhirHelpers_4_3_000.ToValue(context, be_);

						return (bf_ as CqlInterval<CqlDateTime>) as object;
					}
					else if (as_())
					{
						DataType bg_ = O2Saturation?.Effective;
						object bh_ = fhirHelpers_4_3_000.ToValue(context, bg_);

						return (bh_ as CqlDateTime) as object;
					}
					else
					{
						return null;
					}
				};
				CqlDateTime s_ = qiCoreCommon_2_0_000.earliest(context, r_());
				Period t_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> u_ = fhirHelpers_4_3_000.ToInterval(context, t_);
				CqlDateTime v_ = context.Operators.Start(u_);
				CqlQuantity w_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime x_ = context.Operators.Subtract(v_, w_);
				CqlInterval<CqlDateTime> z_ = fhirHelpers_4_3_000.ToInterval(context, t_);
				CqlDateTime aa_ = context.Operators.Start(z_);
				CqlQuantity ab_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime ac_ = context.Operators.Add(aa_, ab_);
				CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(x_, ac_, true, true);
				bool? ae_ = context.Operators.In<CqlDateTime>(s_, ad_, default);
				Code<ObservationStatus> af_ = O2Saturation?.StatusElement;
				ObservationStatus? ag_ = af_?.Value;
				Code<ObservationStatus> ah_ = context.Operators.Convert<Code<ObservationStatus>>(ag_);
				string ai_ = context.Operators.Convert<string>(ah_);
				string[] aj_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ak_ = context.Operators.In<string>(ai_, aj_ as IEnumerable<string>);
				bool? al_ = context.Operators.And(ae_, ak_);
				DataType am_ = O2Saturation?.Value;
				object an_ = fhirHelpers_4_3_000.ToValue(context, am_);
				bool? ao_ = context.Operators.Not((bool?)(an_ is null));
				bool? ap_ = context.Operators.And(al_, ao_);

				return ap_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				object bi_()
				{
					bool bk_()
					{
						DataType bn_ = @this?.Effective;
						object bo_ = fhirHelpers_4_3_000.ToValue(context, bn_);
						bool bp_ = bo_ is CqlDateTime;

						return bp_;
					};
					bool bl_()
					{
						DataType bq_ = @this?.Effective;
						object br_ = fhirHelpers_4_3_000.ToValue(context, bq_);
						bool bs_ = br_ is CqlInterval<CqlDateTime>;

						return bs_;
					};
					bool bm_()
					{
						DataType bt_ = @this?.Effective;
						object bu_ = fhirHelpers_4_3_000.ToValue(context, bt_);
						bool bv_ = bu_ is CqlDateTime;

						return bv_;
					};
					if (bk_())
					{
						DataType bw_ = @this?.Effective;
						object bx_ = fhirHelpers_4_3_000.ToValue(context, bw_);

						return (bx_ as CqlDateTime) as object;
					}
					else if (bl_())
					{
						DataType by_ = @this?.Effective;
						object bz_ = fhirHelpers_4_3_000.ToValue(context, by_);

						return (bz_ as CqlInterval<CqlDateTime>) as object;
					}
					else if (bm_())
					{
						DataType ca_ = @this?.Effective;
						object cb_ = fhirHelpers_4_3_000.ToValue(context, ca_);

						return (cb_ as CqlDateTime) as object;
					}
					else
					{
						return null;
					}
				};
				CqlDateTime bj_ = qiCoreCommon_2_0_000.earliest(context, bi_());

				return bj_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = fhirHelpers_4_3_000.ToValue(context, m_);
			object o_()
			{
				bool cc_()
				{
					CqlValueSet cf_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
					IEnumerable<Observation> cg_ = context.Operators.RetrieveByValueSet<Observation>(cf_, default);
					bool? ch_(Observation O2Saturation)
					{
						object cp_()
						{
							bool do_()
							{
								DataType dr_ = O2Saturation?.Effective;
								object ds_ = fhirHelpers_4_3_000.ToValue(context, dr_);
								bool dt_ = ds_ is CqlDateTime;

								return dt_;
							};
							bool dp_()
							{
								DataType du_ = O2Saturation?.Effective;
								object dv_ = fhirHelpers_4_3_000.ToValue(context, du_);
								bool dw_ = dv_ is CqlInterval<CqlDateTime>;

								return dw_;
							};
							bool dq_()
							{
								DataType dx_ = O2Saturation?.Effective;
								object dy_ = fhirHelpers_4_3_000.ToValue(context, dx_);
								bool dz_ = dy_ is CqlDateTime;

								return dz_;
							};
							if (do_())
							{
								DataType ea_ = O2Saturation?.Effective;
								object eb_ = fhirHelpers_4_3_000.ToValue(context, ea_);

								return (eb_ as CqlDateTime) as object;
							}
							else if (dp_())
							{
								DataType ec_ = O2Saturation?.Effective;
								object ed_ = fhirHelpers_4_3_000.ToValue(context, ec_);

								return (ed_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (dq_())
							{
								DataType ee_ = O2Saturation?.Effective;
								object ef_ = fhirHelpers_4_3_000.ToValue(context, ee_);

								return (ef_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime cq_ = qiCoreCommon_2_0_000.earliest(context, cp_());
						Period cr_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> cs_ = fhirHelpers_4_3_000.ToInterval(context, cr_);
						CqlDateTime ct_ = context.Operators.Start(cs_);
						CqlQuantity cu_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime cv_ = context.Operators.Subtract(ct_, cu_);
						CqlInterval<CqlDateTime> cx_ = fhirHelpers_4_3_000.ToInterval(context, cr_);
						CqlDateTime cy_ = context.Operators.Start(cx_);
						CqlQuantity cz_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime da_ = context.Operators.Add(cy_, cz_);
						CqlInterval<CqlDateTime> db_ = context.Operators.Interval(cv_, da_, true, true);
						bool? dc_ = context.Operators.In<CqlDateTime>(cq_, db_, default);
						Code<ObservationStatus> dd_ = O2Saturation?.StatusElement;
						ObservationStatus? de_ = dd_?.Value;
						Code<ObservationStatus> df_ = context.Operators.Convert<Code<ObservationStatus>>(de_);
						string dg_ = context.Operators.Convert<string>(df_);
						string[] dh_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? di_ = context.Operators.In<string>(dg_, dh_ as IEnumerable<string>);
						bool? dj_ = context.Operators.And(dc_, di_);
						DataType dk_ = O2Saturation?.Value;
						object dl_ = fhirHelpers_4_3_000.ToValue(context, dk_);
						bool? dm_ = context.Operators.Not((bool?)(dl_ is null));
						bool? dn_ = context.Operators.And(dj_, dm_);

						return dn_;
					};
					IEnumerable<Observation> ci_ = context.Operators.Where<Observation>(cg_, ch_);
					object cj_(Observation @this)
					{
						object eg_()
						{
							bool ei_()
							{
								DataType el_ = @this?.Effective;
								object em_ = fhirHelpers_4_3_000.ToValue(context, el_);
								bool en_ = em_ is CqlDateTime;

								return en_;
							};
							bool ej_()
							{
								DataType eo_ = @this?.Effective;
								object ep_ = fhirHelpers_4_3_000.ToValue(context, eo_);
								bool eq_ = ep_ is CqlInterval<CqlDateTime>;

								return eq_;
							};
							bool ek_()
							{
								DataType er_ = @this?.Effective;
								object es_ = fhirHelpers_4_3_000.ToValue(context, er_);
								bool et_ = es_ is CqlDateTime;

								return et_;
							};
							if (ei_())
							{
								DataType eu_ = @this?.Effective;
								object ev_ = fhirHelpers_4_3_000.ToValue(context, eu_);

								return (ev_ as CqlDateTime) as object;
							}
							else if (ej_())
							{
								DataType ew_ = @this?.Effective;
								object ex_ = fhirHelpers_4_3_000.ToValue(context, ew_);

								return (ex_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (ek_())
							{
								DataType ey_ = @this?.Effective;
								object ez_ = fhirHelpers_4_3_000.ToValue(context, ey_);

								return (ez_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime eh_ = qiCoreCommon_2_0_000.earliest(context, eg_());

						return eh_;
					};
					IEnumerable<Observation> ck_ = context.Operators.SortBy<Observation>(ci_, cj_, System.ComponentModel.ListSortDirection.Ascending);
					Observation cl_ = context.Operators.First<Observation>(ck_);
					DataType cm_ = cl_?.Effective;
					object cn_ = fhirHelpers_4_3_000.ToValue(context, cm_);
					bool co_ = cn_ is CqlDateTime;

					return co_;
				};
				bool cd_()
				{
					CqlValueSet fa_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
					IEnumerable<Observation> fb_ = context.Operators.RetrieveByValueSet<Observation>(fa_, default);
					bool? fc_(Observation O2Saturation)
					{
						object fk_()
						{
							bool gj_()
							{
								DataType gm_ = O2Saturation?.Effective;
								object gn_ = fhirHelpers_4_3_000.ToValue(context, gm_);
								bool go_ = gn_ is CqlDateTime;

								return go_;
							};
							bool gk_()
							{
								DataType gp_ = O2Saturation?.Effective;
								object gq_ = fhirHelpers_4_3_000.ToValue(context, gp_);
								bool gr_ = gq_ is CqlInterval<CqlDateTime>;

								return gr_;
							};
							bool gl_()
							{
								DataType gs_ = O2Saturation?.Effective;
								object gt_ = fhirHelpers_4_3_000.ToValue(context, gs_);
								bool gu_ = gt_ is CqlDateTime;

								return gu_;
							};
							if (gj_())
							{
								DataType gv_ = O2Saturation?.Effective;
								object gw_ = fhirHelpers_4_3_000.ToValue(context, gv_);

								return (gw_ as CqlDateTime) as object;
							}
							else if (gk_())
							{
								DataType gx_ = O2Saturation?.Effective;
								object gy_ = fhirHelpers_4_3_000.ToValue(context, gx_);

								return (gy_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (gl_())
							{
								DataType gz_ = O2Saturation?.Effective;
								object ha_ = fhirHelpers_4_3_000.ToValue(context, gz_);

								return (ha_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime fl_ = qiCoreCommon_2_0_000.earliest(context, fk_());
						Period fm_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> fn_ = fhirHelpers_4_3_000.ToInterval(context, fm_);
						CqlDateTime fo_ = context.Operators.Start(fn_);
						CqlQuantity fp_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime fq_ = context.Operators.Subtract(fo_, fp_);
						CqlInterval<CqlDateTime> fs_ = fhirHelpers_4_3_000.ToInterval(context, fm_);
						CqlDateTime ft_ = context.Operators.Start(fs_);
						CqlQuantity fu_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime fv_ = context.Operators.Add(ft_, fu_);
						CqlInterval<CqlDateTime> fw_ = context.Operators.Interval(fq_, fv_, true, true);
						bool? fx_ = context.Operators.In<CqlDateTime>(fl_, fw_, default);
						Code<ObservationStatus> fy_ = O2Saturation?.StatusElement;
						ObservationStatus? fz_ = fy_?.Value;
						Code<ObservationStatus> ga_ = context.Operators.Convert<Code<ObservationStatus>>(fz_);
						string gb_ = context.Operators.Convert<string>(ga_);
						string[] gc_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? gd_ = context.Operators.In<string>(gb_, gc_ as IEnumerable<string>);
						bool? ge_ = context.Operators.And(fx_, gd_);
						DataType gf_ = O2Saturation?.Value;
						object gg_ = fhirHelpers_4_3_000.ToValue(context, gf_);
						bool? gh_ = context.Operators.Not((bool?)(gg_ is null));
						bool? gi_ = context.Operators.And(ge_, gh_);

						return gi_;
					};
					IEnumerable<Observation> fd_ = context.Operators.Where<Observation>(fb_, fc_);
					object fe_(Observation @this)
					{
						object hb_()
						{
							bool hd_()
							{
								DataType hg_ = @this?.Effective;
								object hh_ = fhirHelpers_4_3_000.ToValue(context, hg_);
								bool hi_ = hh_ is CqlDateTime;

								return hi_;
							};
							bool he_()
							{
								DataType hj_ = @this?.Effective;
								object hk_ = fhirHelpers_4_3_000.ToValue(context, hj_);
								bool hl_ = hk_ is CqlInterval<CqlDateTime>;

								return hl_;
							};
							bool hf_()
							{
								DataType hm_ = @this?.Effective;
								object hn_ = fhirHelpers_4_3_000.ToValue(context, hm_);
								bool ho_ = hn_ is CqlDateTime;

								return ho_;
							};
							if (hd_())
							{
								DataType hp_ = @this?.Effective;
								object hq_ = fhirHelpers_4_3_000.ToValue(context, hp_);

								return (hq_ as CqlDateTime) as object;
							}
							else if (he_())
							{
								DataType hr_ = @this?.Effective;
								object hs_ = fhirHelpers_4_3_000.ToValue(context, hr_);

								return (hs_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (hf_())
							{
								DataType ht_ = @this?.Effective;
								object hu_ = fhirHelpers_4_3_000.ToValue(context, ht_);

								return (hu_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime hc_ = qiCoreCommon_2_0_000.earliest(context, hb_());

						return hc_;
					};
					IEnumerable<Observation> ff_ = context.Operators.SortBy<Observation>(fd_, fe_, System.ComponentModel.ListSortDirection.Ascending);
					Observation fg_ = context.Operators.First<Observation>(ff_);
					DataType fh_ = fg_?.Effective;
					object fi_ = fhirHelpers_4_3_000.ToValue(context, fh_);
					bool fj_ = fi_ is CqlInterval<CqlDateTime>;

					return fj_;
				};
				bool ce_()
				{
					CqlValueSet hv_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
					IEnumerable<Observation> hw_ = context.Operators.RetrieveByValueSet<Observation>(hv_, default);
					bool? hx_(Observation O2Saturation)
					{
						object if_()
						{
							bool je_()
							{
								DataType jh_ = O2Saturation?.Effective;
								object ji_ = fhirHelpers_4_3_000.ToValue(context, jh_);
								bool jj_ = ji_ is CqlDateTime;

								return jj_;
							};
							bool jf_()
							{
								DataType jk_ = O2Saturation?.Effective;
								object jl_ = fhirHelpers_4_3_000.ToValue(context, jk_);
								bool jm_ = jl_ is CqlInterval<CqlDateTime>;

								return jm_;
							};
							bool jg_()
							{
								DataType jn_ = O2Saturation?.Effective;
								object jo_ = fhirHelpers_4_3_000.ToValue(context, jn_);
								bool jp_ = jo_ is CqlDateTime;

								return jp_;
							};
							if (je_())
							{
								DataType jq_ = O2Saturation?.Effective;
								object jr_ = fhirHelpers_4_3_000.ToValue(context, jq_);

								return (jr_ as CqlDateTime) as object;
							}
							else if (jf_())
							{
								DataType js_ = O2Saturation?.Effective;
								object jt_ = fhirHelpers_4_3_000.ToValue(context, js_);

								return (jt_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (jg_())
							{
								DataType ju_ = O2Saturation?.Effective;
								object jv_ = fhirHelpers_4_3_000.ToValue(context, ju_);

								return (jv_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime ig_ = qiCoreCommon_2_0_000.earliest(context, if_());
						Period ih_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> ii_ = fhirHelpers_4_3_000.ToInterval(context, ih_);
						CqlDateTime ij_ = context.Operators.Start(ii_);
						CqlQuantity ik_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime il_ = context.Operators.Subtract(ij_, ik_);
						CqlInterval<CqlDateTime> in_ = fhirHelpers_4_3_000.ToInterval(context, ih_);
						CqlDateTime io_ = context.Operators.Start(in_);
						CqlQuantity ip_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime iq_ = context.Operators.Add(io_, ip_);
						CqlInterval<CqlDateTime> ir_ = context.Operators.Interval(il_, iq_, true, true);
						bool? is_ = context.Operators.In<CqlDateTime>(ig_, ir_, default);
						Code<ObservationStatus> it_ = O2Saturation?.StatusElement;
						ObservationStatus? iu_ = it_?.Value;
						Code<ObservationStatus> iv_ = context.Operators.Convert<Code<ObservationStatus>>(iu_);
						string iw_ = context.Operators.Convert<string>(iv_);
						string[] ix_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? iy_ = context.Operators.In<string>(iw_, ix_ as IEnumerable<string>);
						bool? iz_ = context.Operators.And(is_, iy_);
						DataType ja_ = O2Saturation?.Value;
						object jb_ = fhirHelpers_4_3_000.ToValue(context, ja_);
						bool? jc_ = context.Operators.Not((bool?)(jb_ is null));
						bool? jd_ = context.Operators.And(iz_, jc_);

						return jd_;
					};
					IEnumerable<Observation> hy_ = context.Operators.Where<Observation>(hw_, hx_);
					object hz_(Observation @this)
					{
						object jw_()
						{
							bool jy_()
							{
								DataType kb_ = @this?.Effective;
								object kc_ = fhirHelpers_4_3_000.ToValue(context, kb_);
								bool kd_ = kc_ is CqlDateTime;

								return kd_;
							};
							bool jz_()
							{
								DataType ke_ = @this?.Effective;
								object kf_ = fhirHelpers_4_3_000.ToValue(context, ke_);
								bool kg_ = kf_ is CqlInterval<CqlDateTime>;

								return kg_;
							};
							bool ka_()
							{
								DataType kh_ = @this?.Effective;
								object ki_ = fhirHelpers_4_3_000.ToValue(context, kh_);
								bool kj_ = ki_ is CqlDateTime;

								return kj_;
							};
							if (jy_())
							{
								DataType kk_ = @this?.Effective;
								object kl_ = fhirHelpers_4_3_000.ToValue(context, kk_);

								return (kl_ as CqlDateTime) as object;
							}
							else if (jz_())
							{
								DataType km_ = @this?.Effective;
								object kn_ = fhirHelpers_4_3_000.ToValue(context, km_);

								return (kn_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (ka_())
							{
								DataType ko_ = @this?.Effective;
								object kp_ = fhirHelpers_4_3_000.ToValue(context, ko_);

								return (kp_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime jx_ = qiCoreCommon_2_0_000.earliest(context, jw_());

						return jx_;
					};
					IEnumerable<Observation> ia_ = context.Operators.SortBy<Observation>(hy_, hz_, System.ComponentModel.ListSortDirection.Ascending);
					Observation ib_ = context.Operators.First<Observation>(ia_);
					DataType ic_ = ib_?.Effective;
					object id_ = fhirHelpers_4_3_000.ToValue(context, ic_);
					bool ie_ = id_ is CqlDateTime;

					return ie_;
				};
				if (cc_())
				{
					CqlValueSet kq_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
					IEnumerable<Observation> kr_ = context.Operators.RetrieveByValueSet<Observation>(kq_, default);
					bool? ks_(Observation O2Saturation)
					{
						object kz_()
						{
							bool ly_()
							{
								DataType mb_ = O2Saturation?.Effective;
								object mc_ = fhirHelpers_4_3_000.ToValue(context, mb_);
								bool md_ = mc_ is CqlDateTime;

								return md_;
							};
							bool lz_()
							{
								DataType me_ = O2Saturation?.Effective;
								object mf_ = fhirHelpers_4_3_000.ToValue(context, me_);
								bool mg_ = mf_ is CqlInterval<CqlDateTime>;

								return mg_;
							};
							bool ma_()
							{
								DataType mh_ = O2Saturation?.Effective;
								object mi_ = fhirHelpers_4_3_000.ToValue(context, mh_);
								bool mj_ = mi_ is CqlDateTime;

								return mj_;
							};
							if (ly_())
							{
								DataType mk_ = O2Saturation?.Effective;
								object ml_ = fhirHelpers_4_3_000.ToValue(context, mk_);

								return (ml_ as CqlDateTime) as object;
							}
							else if (lz_())
							{
								DataType mm_ = O2Saturation?.Effective;
								object mn_ = fhirHelpers_4_3_000.ToValue(context, mm_);

								return (mn_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (ma_())
							{
								DataType mo_ = O2Saturation?.Effective;
								object mp_ = fhirHelpers_4_3_000.ToValue(context, mo_);

								return (mp_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime la_ = qiCoreCommon_2_0_000.earliest(context, kz_());
						Period lb_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> lc_ = fhirHelpers_4_3_000.ToInterval(context, lb_);
						CqlDateTime ld_ = context.Operators.Start(lc_);
						CqlQuantity le_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime lf_ = context.Operators.Subtract(ld_, le_);
						CqlInterval<CqlDateTime> lh_ = fhirHelpers_4_3_000.ToInterval(context, lb_);
						CqlDateTime li_ = context.Operators.Start(lh_);
						CqlQuantity lj_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime lk_ = context.Operators.Add(li_, lj_);
						CqlInterval<CqlDateTime> ll_ = context.Operators.Interval(lf_, lk_, true, true);
						bool? lm_ = context.Operators.In<CqlDateTime>(la_, ll_, default);
						Code<ObservationStatus> ln_ = O2Saturation?.StatusElement;
						ObservationStatus? lo_ = ln_?.Value;
						Code<ObservationStatus> lp_ = context.Operators.Convert<Code<ObservationStatus>>(lo_);
						string lq_ = context.Operators.Convert<string>(lp_);
						string[] lr_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? ls_ = context.Operators.In<string>(lq_, lr_ as IEnumerable<string>);
						bool? lt_ = context.Operators.And(lm_, ls_);
						DataType lu_ = O2Saturation?.Value;
						object lv_ = fhirHelpers_4_3_000.ToValue(context, lu_);
						bool? lw_ = context.Operators.Not((bool?)(lv_ is null));
						bool? lx_ = context.Operators.And(lt_, lw_);

						return lx_;
					};
					IEnumerable<Observation> kt_ = context.Operators.Where<Observation>(kr_, ks_);
					object ku_(Observation @this)
					{
						object mq_()
						{
							bool ms_()
							{
								DataType mv_ = @this?.Effective;
								object mw_ = fhirHelpers_4_3_000.ToValue(context, mv_);
								bool mx_ = mw_ is CqlDateTime;

								return mx_;
							};
							bool mt_()
							{
								DataType my_ = @this?.Effective;
								object mz_ = fhirHelpers_4_3_000.ToValue(context, my_);
								bool na_ = mz_ is CqlInterval<CqlDateTime>;

								return na_;
							};
							bool mu_()
							{
								DataType nb_ = @this?.Effective;
								object nc_ = fhirHelpers_4_3_000.ToValue(context, nb_);
								bool nd_ = nc_ is CqlDateTime;

								return nd_;
							};
							if (ms_())
							{
								DataType ne_ = @this?.Effective;
								object nf_ = fhirHelpers_4_3_000.ToValue(context, ne_);

								return (nf_ as CqlDateTime) as object;
							}
							else if (mt_())
							{
								DataType ng_ = @this?.Effective;
								object nh_ = fhirHelpers_4_3_000.ToValue(context, ng_);

								return (nh_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (mu_())
							{
								DataType ni_ = @this?.Effective;
								object nj_ = fhirHelpers_4_3_000.ToValue(context, ni_);

								return (nj_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime mr_ = qiCoreCommon_2_0_000.earliest(context, mq_());

						return mr_;
					};
					IEnumerable<Observation> kv_ = context.Operators.SortBy<Observation>(kt_, ku_, System.ComponentModel.ListSortDirection.Ascending);
					Observation kw_ = context.Operators.First<Observation>(kv_);
					DataType kx_ = kw_?.Effective;
					object ky_ = fhirHelpers_4_3_000.ToValue(context, kx_);

					return (ky_ as CqlDateTime) as object;
				}
				else if (cd_())
				{
					CqlValueSet nk_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
					IEnumerable<Observation> nl_ = context.Operators.RetrieveByValueSet<Observation>(nk_, default);
					bool? nm_(Observation O2Saturation)
					{
						object nt_()
						{
							bool os_()
							{
								DataType ov_ = O2Saturation?.Effective;
								object ow_ = fhirHelpers_4_3_000.ToValue(context, ov_);
								bool ox_ = ow_ is CqlDateTime;

								return ox_;
							};
							bool ot_()
							{
								DataType oy_ = O2Saturation?.Effective;
								object oz_ = fhirHelpers_4_3_000.ToValue(context, oy_);
								bool pa_ = oz_ is CqlInterval<CqlDateTime>;

								return pa_;
							};
							bool ou_()
							{
								DataType pb_ = O2Saturation?.Effective;
								object pc_ = fhirHelpers_4_3_000.ToValue(context, pb_);
								bool pd_ = pc_ is CqlDateTime;

								return pd_;
							};
							if (os_())
							{
								DataType pe_ = O2Saturation?.Effective;
								object pf_ = fhirHelpers_4_3_000.ToValue(context, pe_);

								return (pf_ as CqlDateTime) as object;
							}
							else if (ot_())
							{
								DataType pg_ = O2Saturation?.Effective;
								object ph_ = fhirHelpers_4_3_000.ToValue(context, pg_);

								return (ph_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (ou_())
							{
								DataType pi_ = O2Saturation?.Effective;
								object pj_ = fhirHelpers_4_3_000.ToValue(context, pi_);

								return (pj_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime nu_ = qiCoreCommon_2_0_000.earliest(context, nt_());
						Period nv_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> nw_ = fhirHelpers_4_3_000.ToInterval(context, nv_);
						CqlDateTime nx_ = context.Operators.Start(nw_);
						CqlQuantity ny_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime nz_ = context.Operators.Subtract(nx_, ny_);
						CqlInterval<CqlDateTime> ob_ = fhirHelpers_4_3_000.ToInterval(context, nv_);
						CqlDateTime oc_ = context.Operators.Start(ob_);
						CqlQuantity od_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime oe_ = context.Operators.Add(oc_, od_);
						CqlInterval<CqlDateTime> of_ = context.Operators.Interval(nz_, oe_, true, true);
						bool? og_ = context.Operators.In<CqlDateTime>(nu_, of_, default);
						Code<ObservationStatus> oh_ = O2Saturation?.StatusElement;
						ObservationStatus? oi_ = oh_?.Value;
						Code<ObservationStatus> oj_ = context.Operators.Convert<Code<ObservationStatus>>(oi_);
						string ok_ = context.Operators.Convert<string>(oj_);
						string[] ol_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? om_ = context.Operators.In<string>(ok_, ol_ as IEnumerable<string>);
						bool? on_ = context.Operators.And(og_, om_);
						DataType oo_ = O2Saturation?.Value;
						object op_ = fhirHelpers_4_3_000.ToValue(context, oo_);
						bool? oq_ = context.Operators.Not((bool?)(op_ is null));
						bool? or_ = context.Operators.And(on_, oq_);

						return or_;
					};
					IEnumerable<Observation> nn_ = context.Operators.Where<Observation>(nl_, nm_);
					object no_(Observation @this)
					{
						object pk_()
						{
							bool pm_()
							{
								DataType pp_ = @this?.Effective;
								object pq_ = fhirHelpers_4_3_000.ToValue(context, pp_);
								bool pr_ = pq_ is CqlDateTime;

								return pr_;
							};
							bool pn_()
							{
								DataType ps_ = @this?.Effective;
								object pt_ = fhirHelpers_4_3_000.ToValue(context, ps_);
								bool pu_ = pt_ is CqlInterval<CqlDateTime>;

								return pu_;
							};
							bool po_()
							{
								DataType pv_ = @this?.Effective;
								object pw_ = fhirHelpers_4_3_000.ToValue(context, pv_);
								bool px_ = pw_ is CqlDateTime;

								return px_;
							};
							if (pm_())
							{
								DataType py_ = @this?.Effective;
								object pz_ = fhirHelpers_4_3_000.ToValue(context, py_);

								return (pz_ as CqlDateTime) as object;
							}
							else if (pn_())
							{
								DataType qa_ = @this?.Effective;
								object qb_ = fhirHelpers_4_3_000.ToValue(context, qa_);

								return (qb_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (po_())
							{
								DataType qc_ = @this?.Effective;
								object qd_ = fhirHelpers_4_3_000.ToValue(context, qc_);

								return (qd_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime pl_ = qiCoreCommon_2_0_000.earliest(context, pk_());

						return pl_;
					};
					IEnumerable<Observation> np_ = context.Operators.SortBy<Observation>(nn_, no_, System.ComponentModel.ListSortDirection.Ascending);
					Observation nq_ = context.Operators.First<Observation>(np_);
					DataType nr_ = nq_?.Effective;
					object ns_ = fhirHelpers_4_3_000.ToValue(context, nr_);

					return (ns_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (ce_())
				{
					CqlValueSet qe_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
					IEnumerable<Observation> qf_ = context.Operators.RetrieveByValueSet<Observation>(qe_, default);
					bool? qg_(Observation O2Saturation)
					{
						object qn_()
						{
							bool rm_()
							{
								DataType rp_ = O2Saturation?.Effective;
								object rq_ = fhirHelpers_4_3_000.ToValue(context, rp_);
								bool rr_ = rq_ is CqlDateTime;

								return rr_;
							};
							bool rn_()
							{
								DataType rs_ = O2Saturation?.Effective;
								object rt_ = fhirHelpers_4_3_000.ToValue(context, rs_);
								bool ru_ = rt_ is CqlInterval<CqlDateTime>;

								return ru_;
							};
							bool ro_()
							{
								DataType rv_ = O2Saturation?.Effective;
								object rw_ = fhirHelpers_4_3_000.ToValue(context, rv_);
								bool rx_ = rw_ is CqlDateTime;

								return rx_;
							};
							if (rm_())
							{
								DataType ry_ = O2Saturation?.Effective;
								object rz_ = fhirHelpers_4_3_000.ToValue(context, ry_);

								return (rz_ as CqlDateTime) as object;
							}
							else if (rn_())
							{
								DataType sa_ = O2Saturation?.Effective;
								object sb_ = fhirHelpers_4_3_000.ToValue(context, sa_);

								return (sb_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (ro_())
							{
								DataType sc_ = O2Saturation?.Effective;
								object sd_ = fhirHelpers_4_3_000.ToValue(context, sc_);

								return (sd_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime qo_ = qiCoreCommon_2_0_000.earliest(context, qn_());
						Period qp_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> qq_ = fhirHelpers_4_3_000.ToInterval(context, qp_);
						CqlDateTime qr_ = context.Operators.Start(qq_);
						CqlQuantity qs_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime qt_ = context.Operators.Subtract(qr_, qs_);
						CqlInterval<CqlDateTime> qv_ = fhirHelpers_4_3_000.ToInterval(context, qp_);
						CqlDateTime qw_ = context.Operators.Start(qv_);
						CqlQuantity qx_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime qy_ = context.Operators.Add(qw_, qx_);
						CqlInterval<CqlDateTime> qz_ = context.Operators.Interval(qt_, qy_, true, true);
						bool? ra_ = context.Operators.In<CqlDateTime>(qo_, qz_, default);
						Code<ObservationStatus> rb_ = O2Saturation?.StatusElement;
						ObservationStatus? rc_ = rb_?.Value;
						Code<ObservationStatus> rd_ = context.Operators.Convert<Code<ObservationStatus>>(rc_);
						string re_ = context.Operators.Convert<string>(rd_);
						string[] rf_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? rg_ = context.Operators.In<string>(re_, rf_ as IEnumerable<string>);
						bool? rh_ = context.Operators.And(ra_, rg_);
						DataType ri_ = O2Saturation?.Value;
						object rj_ = fhirHelpers_4_3_000.ToValue(context, ri_);
						bool? rk_ = context.Operators.Not((bool?)(rj_ is null));
						bool? rl_ = context.Operators.And(rh_, rk_);

						return rl_;
					};
					IEnumerable<Observation> qh_ = context.Operators.Where<Observation>(qf_, qg_);
					object qi_(Observation @this)
					{
						object se_()
						{
							bool sg_()
							{
								DataType sj_ = @this?.Effective;
								object sk_ = fhirHelpers_4_3_000.ToValue(context, sj_);
								bool sl_ = sk_ is CqlDateTime;

								return sl_;
							};
							bool sh_()
							{
								DataType sm_ = @this?.Effective;
								object sn_ = fhirHelpers_4_3_000.ToValue(context, sm_);
								bool so_ = sn_ is CqlInterval<CqlDateTime>;

								return so_;
							};
							bool si_()
							{
								DataType sp_ = @this?.Effective;
								object sq_ = fhirHelpers_4_3_000.ToValue(context, sp_);
								bool sr_ = sq_ is CqlDateTime;

								return sr_;
							};
							if (sg_())
							{
								DataType ss_ = @this?.Effective;
								object st_ = fhirHelpers_4_3_000.ToValue(context, ss_);

								return (st_ as CqlDateTime) as object;
							}
							else if (sh_())
							{
								DataType su_ = @this?.Effective;
								object sv_ = fhirHelpers_4_3_000.ToValue(context, su_);

								return (sv_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (si_())
							{
								DataType sw_ = @this?.Effective;
								object sx_ = fhirHelpers_4_3_000.ToValue(context, sw_);

								return (sx_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime sf_ = qiCoreCommon_2_0_000.earliest(context, se_());

						return sf_;
					};
					IEnumerable<Observation> qj_ = context.Operators.SortBy<Observation>(qh_, qi_, System.ComponentModel.ListSortDirection.Ascending);
					Observation qk_ = context.Operators.First<Observation>(qj_);
					DataType ql_ = qk_?.Effective;
					object qm_ = fhirHelpers_4_3_000.ToValue(context, ql_);

					return (qm_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime p_ = qiCoreCommon_2_0_000.earliest(context, o_());
			(string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? q_ = (e_, n_ as CqlQuantity, p_);

			return q_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Blood Pressure Reading")]
	public IEnumerable<Observation> Blood_Pressure_Reading(CqlContext context)
	{
		IEnumerable<Observation> a_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
		bool? b_(Observation BloodPressure)
		{
			Code<ObservationStatus> d_ = BloodPressure?.StatusElement;
			ObservationStatus? e_ = d_?.Value;
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);

			return h_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Systolic Blood Pressure")]
	public IEnumerable<Encounter> Encounter_with_First_Systolic_Blood_Pressure(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

		return a_;
	}

    [CqlDeclaration("Encounter with First Bicarbonate Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
		(string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Bicarbonate_lab_test(context);
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation BicarbonateLab)
			{
				Instant z_ = BicarbonateLab?.IssuedElement;
				DateTimeOffset? aa_ = z_?.Value;
				CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				CqlDateTime ac_ = qiCoreCommon_2_0_000.earliest(context, ab_ as object);
				Period ad_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> ae_ = fhirHelpers_4_3_000.ToInterval(context, ad_);
				CqlDateTime af_ = context.Operators.Start(ae_);
				CqlQuantity ag_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ah_ = context.Operators.Subtract(af_, ag_);
				CqlInterval<CqlDateTime> aj_ = fhirHelpers_4_3_000.ToInterval(context, ad_);
				CqlDateTime ak_ = context.Operators.Start(aj_);
				CqlDateTime am_ = context.Operators.Add(ak_, ag_);
				CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ah_, am_, true, true);
				bool? ao_ = context.Operators.In<CqlDateTime>(ac_, an_, default);
				Code<ObservationStatus> ap_ = BicarbonateLab?.StatusElement;
				ObservationStatus? aq_ = ap_?.Value;
				string ar_ = context.Operators.Convert<string>(aq_);
				string[] as_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? at_ = context.Operators.In<string>(ar_, as_ as IEnumerable<string>);
				bool? au_ = context.Operators.And(ao_, at_);
				DataType av_ = BicarbonateLab?.Value;
				object aw_ = fhirHelpers_4_3_000.ToValue(context, av_);
				bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
				bool? ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant az_ = @this?.IssuedElement;
				DateTimeOffset? ba_ = az_?.Value;
				CqlDateTime bb_ = context.Operators.Convert<CqlDateTime>(ba_);
				CqlDateTime bc_ = qiCoreCommon_2_0_000.earliest(context, bb_ as object);

				return bc_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = fhirHelpers_4_3_000.ToValue(context, m_);
			IEnumerable<Observation> p_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? q_(Observation BicarbonateLab)
			{
				Instant bd_ = BicarbonateLab?.IssuedElement;
				DateTimeOffset? be_ = bd_?.Value;
				CqlDateTime bf_ = context.Operators.Convert<CqlDateTime>(be_);
				CqlDateTime bg_ = qiCoreCommon_2_0_000.earliest(context, bf_ as object);
				Period bh_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bi_ = fhirHelpers_4_3_000.ToInterval(context, bh_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlQuantity bk_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bl_ = context.Operators.Subtract(bj_, bk_);
				CqlInterval<CqlDateTime> bn_ = fhirHelpers_4_3_000.ToInterval(context, bh_);
				CqlDateTime bo_ = context.Operators.Start(bn_);
				CqlDateTime bq_ = context.Operators.Add(bo_, bk_);
				CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bl_, bq_, true, true);
				bool? bs_ = context.Operators.In<CqlDateTime>(bg_, br_, default);
				Code<ObservationStatus> bt_ = BicarbonateLab?.StatusElement;
				ObservationStatus? bu_ = bt_?.Value;
				string bv_ = context.Operators.Convert<string>(bu_);
				string[] bw_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bx_ = context.Operators.In<string>(bv_, bw_ as IEnumerable<string>);
				bool? by_ = context.Operators.And(bs_, bx_);
				DataType bz_ = BicarbonateLab?.Value;
				object ca_ = fhirHelpers_4_3_000.ToValue(context, bz_);
				bool? cb_ = context.Operators.Not((bool?)(ca_ is null));
				bool? cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			IEnumerable<Observation> r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				Instant cd_ = @this?.IssuedElement;
				DateTimeOffset? ce_ = cd_?.Value;
				CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
				CqlDateTime cg_ = qiCoreCommon_2_0_000.earliest(context, cf_ as object);

				return cg_;
			};
			IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Observation u_ = context.Operators.First<Observation>(t_);
			Instant v_ = u_?.IssuedElement;
			DateTimeOffset? w_ = v_?.Value;
			CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
			(string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? y_ = (e_, n_ as CqlQuantity, x_);

			return y_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Creatinine Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
		(string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Creatinine_lab_test(context);
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation CreatinineLab)
			{
				Instant z_ = CreatinineLab?.IssuedElement;
				DateTimeOffset? aa_ = z_?.Value;
				CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				CqlDateTime ac_ = qiCoreCommon_2_0_000.earliest(context, ab_ as object);
				Period ad_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> ae_ = fhirHelpers_4_3_000.ToInterval(context, ad_);
				CqlDateTime af_ = context.Operators.Start(ae_);
				CqlQuantity ag_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ah_ = context.Operators.Subtract(af_, ag_);
				CqlInterval<CqlDateTime> aj_ = fhirHelpers_4_3_000.ToInterval(context, ad_);
				CqlDateTime ak_ = context.Operators.Start(aj_);
				CqlDateTime am_ = context.Operators.Add(ak_, ag_);
				CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ah_, am_, true, true);
				bool? ao_ = context.Operators.In<CqlDateTime>(ac_, an_, default);
				Code<ObservationStatus> ap_ = CreatinineLab?.StatusElement;
				ObservationStatus? aq_ = ap_?.Value;
				string ar_ = context.Operators.Convert<string>(aq_);
				string[] as_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? at_ = context.Operators.In<string>(ar_, as_ as IEnumerable<string>);
				bool? au_ = context.Operators.And(ao_, at_);
				DataType av_ = CreatinineLab?.Value;
				object aw_ = fhirHelpers_4_3_000.ToValue(context, av_);
				bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
				bool? ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant az_ = @this?.IssuedElement;
				DateTimeOffset? ba_ = az_?.Value;
				CqlDateTime bb_ = context.Operators.Convert<CqlDateTime>(ba_);
				CqlDateTime bc_ = qiCoreCommon_2_0_000.earliest(context, bb_ as object);

				return bc_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = fhirHelpers_4_3_000.ToValue(context, m_);
			IEnumerable<Observation> p_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? q_(Observation CreatinineLab)
			{
				Instant bd_ = CreatinineLab?.IssuedElement;
				DateTimeOffset? be_ = bd_?.Value;
				CqlDateTime bf_ = context.Operators.Convert<CqlDateTime>(be_);
				CqlDateTime bg_ = qiCoreCommon_2_0_000.earliest(context, bf_ as object);
				Period bh_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bi_ = fhirHelpers_4_3_000.ToInterval(context, bh_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlQuantity bk_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bl_ = context.Operators.Subtract(bj_, bk_);
				CqlInterval<CqlDateTime> bn_ = fhirHelpers_4_3_000.ToInterval(context, bh_);
				CqlDateTime bo_ = context.Operators.Start(bn_);
				CqlDateTime bq_ = context.Operators.Add(bo_, bk_);
				CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bl_, bq_, true, true);
				bool? bs_ = context.Operators.In<CqlDateTime>(bg_, br_, default);
				Code<ObservationStatus> bt_ = CreatinineLab?.StatusElement;
				ObservationStatus? bu_ = bt_?.Value;
				string bv_ = context.Operators.Convert<string>(bu_);
				string[] bw_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bx_ = context.Operators.In<string>(bv_, bw_ as IEnumerable<string>);
				bool? by_ = context.Operators.And(bs_, bx_);
				DataType bz_ = CreatinineLab?.Value;
				object ca_ = fhirHelpers_4_3_000.ToValue(context, bz_);
				bool? cb_ = context.Operators.Not((bool?)(ca_ is null));
				bool? cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			IEnumerable<Observation> r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				Instant cd_ = @this?.IssuedElement;
				DateTimeOffset? ce_ = cd_?.Value;
				CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
				CqlDateTime cg_ = qiCoreCommon_2_0_000.earliest(context, cf_ as object);

				return cg_;
			};
			IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Observation u_ = context.Operators.First<Observation>(t_);
			Instant v_ = u_?.IssuedElement;
			DateTimeOffset? w_ = v_?.Value;
			CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
			(string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? y_ = (e_, n_ as CqlQuantity, x_);

			return y_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Hematocrit Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
		(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Hematocrit_lab_test(context);
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation HematocritLab)
			{
				Instant z_ = HematocritLab?.IssuedElement;
				DateTimeOffset? aa_ = z_?.Value;
				CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				CqlDateTime ac_ = qiCoreCommon_2_0_000.earliest(context, ab_ as object);
				Period ad_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> ae_ = fhirHelpers_4_3_000.ToInterval(context, ad_);
				CqlDateTime af_ = context.Operators.Start(ae_);
				CqlQuantity ag_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ah_ = context.Operators.Subtract(af_, ag_);
				CqlInterval<CqlDateTime> aj_ = fhirHelpers_4_3_000.ToInterval(context, ad_);
				CqlDateTime ak_ = context.Operators.Start(aj_);
				CqlDateTime am_ = context.Operators.Add(ak_, ag_);
				CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ah_, am_, true, true);
				bool? ao_ = context.Operators.In<CqlDateTime>(ac_, an_, default);
				Code<ObservationStatus> ap_ = HematocritLab?.StatusElement;
				ObservationStatus? aq_ = ap_?.Value;
				string ar_ = context.Operators.Convert<string>(aq_);
				string[] as_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? at_ = context.Operators.In<string>(ar_, as_ as IEnumerable<string>);
				bool? au_ = context.Operators.And(ao_, at_);
				DataType av_ = HematocritLab?.Value;
				object aw_ = fhirHelpers_4_3_000.ToValue(context, av_);
				bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
				bool? ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant az_ = @this?.IssuedElement;
				DateTimeOffset? ba_ = az_?.Value;
				CqlDateTime bb_ = context.Operators.Convert<CqlDateTime>(ba_);
				CqlDateTime bc_ = qiCoreCommon_2_0_000.earliest(context, bb_ as object);

				return bc_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = fhirHelpers_4_3_000.ToValue(context, m_);
			IEnumerable<Observation> p_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? q_(Observation HematocritLab)
			{
				Instant bd_ = HematocritLab?.IssuedElement;
				DateTimeOffset? be_ = bd_?.Value;
				CqlDateTime bf_ = context.Operators.Convert<CqlDateTime>(be_);
				CqlDateTime bg_ = qiCoreCommon_2_0_000.earliest(context, bf_ as object);
				Period bh_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bi_ = fhirHelpers_4_3_000.ToInterval(context, bh_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlQuantity bk_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bl_ = context.Operators.Subtract(bj_, bk_);
				CqlInterval<CqlDateTime> bn_ = fhirHelpers_4_3_000.ToInterval(context, bh_);
				CqlDateTime bo_ = context.Operators.Start(bn_);
				CqlDateTime bq_ = context.Operators.Add(bo_, bk_);
				CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bl_, bq_, true, true);
				bool? bs_ = context.Operators.In<CqlDateTime>(bg_, br_, default);
				Code<ObservationStatus> bt_ = HematocritLab?.StatusElement;
				ObservationStatus? bu_ = bt_?.Value;
				string bv_ = context.Operators.Convert<string>(bu_);
				string[] bw_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bx_ = context.Operators.In<string>(bv_, bw_ as IEnumerable<string>);
				bool? by_ = context.Operators.And(bs_, bx_);
				DataType bz_ = HematocritLab?.Value;
				object ca_ = fhirHelpers_4_3_000.ToValue(context, bz_);
				bool? cb_ = context.Operators.Not((bool?)(ca_ is null));
				bool? cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			IEnumerable<Observation> r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				Instant cd_ = @this?.IssuedElement;
				DateTimeOffset? ce_ = cd_?.Value;
				CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
				CqlDateTime cg_ = qiCoreCommon_2_0_000.earliest(context, cf_ as object);

				return cg_;
			};
			IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Observation u_ = context.Operators.First<Observation>(t_);
			Instant v_ = u_?.IssuedElement;
			DateTimeOffset? w_ = v_?.Value;
			CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
			(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? y_ = (e_, n_ as CqlQuantity, x_);

			return y_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Platelet Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> Encounter_with_First_Platelet_Lab_Test(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
		(string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Platelet_count_lab_test(context);
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation PlateletLab)
			{
				Instant z_ = PlateletLab?.IssuedElement;
				DateTimeOffset? aa_ = z_?.Value;
				CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				CqlDateTime ac_ = qiCoreCommon_2_0_000.earliest(context, ab_ as object);
				Period ad_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> ae_ = fhirHelpers_4_3_000.ToInterval(context, ad_);
				CqlDateTime af_ = context.Operators.Start(ae_);
				CqlQuantity ag_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ah_ = context.Operators.Subtract(af_, ag_);
				CqlInterval<CqlDateTime> aj_ = fhirHelpers_4_3_000.ToInterval(context, ad_);
				CqlDateTime ak_ = context.Operators.Start(aj_);
				CqlDateTime am_ = context.Operators.Add(ak_, ag_);
				CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ah_, am_, true, true);
				bool? ao_ = context.Operators.In<CqlDateTime>(ac_, an_, default);
				Code<ObservationStatus> ap_ = PlateletLab?.StatusElement;
				ObservationStatus? aq_ = ap_?.Value;
				string ar_ = context.Operators.Convert<string>(aq_);
				string[] as_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? at_ = context.Operators.In<string>(ar_, as_ as IEnumerable<string>);
				bool? au_ = context.Operators.And(ao_, at_);
				DataType av_ = PlateletLab?.Value;
				object aw_ = fhirHelpers_4_3_000.ToValue(context, av_);
				bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
				bool? ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant az_ = @this?.IssuedElement;
				DateTimeOffset? ba_ = az_?.Value;
				CqlDateTime bb_ = context.Operators.Convert<CqlDateTime>(ba_);
				CqlDateTime bc_ = qiCoreCommon_2_0_000.earliest(context, bb_ as object);

				return bc_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = fhirHelpers_4_3_000.ToValue(context, m_);
			IEnumerable<Observation> p_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? q_(Observation PlateletLab)
			{
				Instant bd_ = PlateletLab?.IssuedElement;
				DateTimeOffset? be_ = bd_?.Value;
				CqlDateTime bf_ = context.Operators.Convert<CqlDateTime>(be_);
				CqlDateTime bg_ = qiCoreCommon_2_0_000.earliest(context, bf_ as object);
				Period bh_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bi_ = fhirHelpers_4_3_000.ToInterval(context, bh_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlQuantity bk_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bl_ = context.Operators.Subtract(bj_, bk_);
				CqlInterval<CqlDateTime> bn_ = fhirHelpers_4_3_000.ToInterval(context, bh_);
				CqlDateTime bo_ = context.Operators.Start(bn_);
				CqlDateTime bq_ = context.Operators.Add(bo_, bk_);
				CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bl_, bq_, true, true);
				bool? bs_ = context.Operators.In<CqlDateTime>(bg_, br_, default);
				Code<ObservationStatus> bt_ = PlateletLab?.StatusElement;
				ObservationStatus? bu_ = bt_?.Value;
				string bv_ = context.Operators.Convert<string>(bu_);
				string[] bw_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bx_ = context.Operators.In<string>(bv_, bw_ as IEnumerable<string>);
				bool? by_ = context.Operators.And(bs_, bx_);
				DataType bz_ = PlateletLab?.Value;
				object ca_ = fhirHelpers_4_3_000.ToValue(context, bz_);
				bool? cb_ = context.Operators.Not((bool?)(ca_ is null));
				bool? cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			IEnumerable<Observation> r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				Instant cd_ = @this?.IssuedElement;
				DateTimeOffset? ce_ = cd_?.Value;
				CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
				CqlDateTime cg_ = qiCoreCommon_2_0_000.earliest(context, cf_ as object);

				return cg_;
			};
			IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Observation u_ = context.Operators.First<Observation>(t_);
			Instant v_ = u_?.IssuedElement;
			DateTimeOffset? w_ = v_?.Value;
			CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
			(string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? y_ = (e_, n_ as CqlQuantity, x_);

			return y_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Sodium Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
		(string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Sodium_lab_test(context);
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation SodiumLab)
			{
				Instant z_ = SodiumLab?.IssuedElement;
				DateTimeOffset? aa_ = z_?.Value;
				CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				CqlDateTime ac_ = qiCoreCommon_2_0_000.earliest(context, ab_ as object);
				Period ad_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> ae_ = fhirHelpers_4_3_000.ToInterval(context, ad_);
				CqlDateTime af_ = context.Operators.Start(ae_);
				CqlQuantity ag_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ah_ = context.Operators.Subtract(af_, ag_);
				CqlInterval<CqlDateTime> aj_ = fhirHelpers_4_3_000.ToInterval(context, ad_);
				CqlDateTime ak_ = context.Operators.Start(aj_);
				CqlDateTime am_ = context.Operators.Add(ak_, ag_);
				CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ah_, am_, true, true);
				bool? ao_ = context.Operators.In<CqlDateTime>(ac_, an_, default);
				Code<ObservationStatus> ap_ = SodiumLab?.StatusElement;
				ObservationStatus? aq_ = ap_?.Value;
				string ar_ = context.Operators.Convert<string>(aq_);
				string[] as_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? at_ = context.Operators.In<string>(ar_, as_ as IEnumerable<string>);
				bool? au_ = context.Operators.And(ao_, at_);
				DataType av_ = SodiumLab?.Value;
				object aw_ = fhirHelpers_4_3_000.ToValue(context, av_);
				bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
				bool? ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant az_ = @this?.IssuedElement;
				DateTimeOffset? ba_ = az_?.Value;
				CqlDateTime bb_ = context.Operators.Convert<CqlDateTime>(ba_);
				CqlDateTime bc_ = qiCoreCommon_2_0_000.earliest(context, bb_ as object);

				return bc_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = fhirHelpers_4_3_000.ToValue(context, m_);
			IEnumerable<Observation> p_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? q_(Observation SodiumLab)
			{
				Instant bd_ = SodiumLab?.IssuedElement;
				DateTimeOffset? be_ = bd_?.Value;
				CqlDateTime bf_ = context.Operators.Convert<CqlDateTime>(be_);
				CqlDateTime bg_ = qiCoreCommon_2_0_000.earliest(context, bf_ as object);
				Period bh_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bi_ = fhirHelpers_4_3_000.ToInterval(context, bh_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlQuantity bk_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bl_ = context.Operators.Subtract(bj_, bk_);
				CqlInterval<CqlDateTime> bn_ = fhirHelpers_4_3_000.ToInterval(context, bh_);
				CqlDateTime bo_ = context.Operators.Start(bn_);
				CqlDateTime bq_ = context.Operators.Add(bo_, bk_);
				CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bl_, bq_, true, true);
				bool? bs_ = context.Operators.In<CqlDateTime>(bg_, br_, default);
				Code<ObservationStatus> bt_ = SodiumLab?.StatusElement;
				ObservationStatus? bu_ = bt_?.Value;
				string bv_ = context.Operators.Convert<string>(bu_);
				string[] bw_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bx_ = context.Operators.In<string>(bv_, bw_ as IEnumerable<string>);
				bool? by_ = context.Operators.And(bs_, bx_);
				DataType bz_ = SodiumLab?.Value;
				object ca_ = fhirHelpers_4_3_000.ToValue(context, bz_);
				bool? cb_ = context.Operators.Not((bool?)(ca_ is null));
				bool? cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			IEnumerable<Observation> r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				Instant cd_ = @this?.IssuedElement;
				DateTimeOffset? ce_ = cd_?.Value;
				CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
				CqlDateTime cg_ = qiCoreCommon_2_0_000.earliest(context, cf_ as object);

				return cg_;
			};
			IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Observation u_ = context.Operators.First<Observation>(t_);
			Instant v_ = u_?.IssuedElement;
			DateTimeOffset? w_ = v_?.Value;
			CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
			(string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? y_ = (e_, n_ as CqlQuantity, x_);

			return y_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First White Blood Cells Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
		(string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.White_blood_cells_count_lab_test(context);
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation WhiteBloodCellLab)
			{
				Instant z_ = WhiteBloodCellLab?.IssuedElement;
				DateTimeOffset? aa_ = z_?.Value;
				CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				CqlDateTime ac_ = qiCoreCommon_2_0_000.earliest(context, ab_ as object);
				Period ad_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> ae_ = fhirHelpers_4_3_000.ToInterval(context, ad_);
				CqlDateTime af_ = context.Operators.Start(ae_);
				CqlQuantity ag_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ah_ = context.Operators.Subtract(af_, ag_);
				CqlInterval<CqlDateTime> aj_ = fhirHelpers_4_3_000.ToInterval(context, ad_);
				CqlDateTime ak_ = context.Operators.Start(aj_);
				CqlDateTime am_ = context.Operators.Add(ak_, ag_);
				CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ah_, am_, true, true);
				bool? ao_ = context.Operators.In<CqlDateTime>(ac_, an_, default);
				Code<ObservationStatus> ap_ = WhiteBloodCellLab?.StatusElement;
				ObservationStatus? aq_ = ap_?.Value;
				string ar_ = context.Operators.Convert<string>(aq_);
				string[] as_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? at_ = context.Operators.In<string>(ar_, as_ as IEnumerable<string>);
				bool? au_ = context.Operators.And(ao_, at_);
				DataType av_ = WhiteBloodCellLab?.Value;
				object aw_ = fhirHelpers_4_3_000.ToValue(context, av_);
				bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
				bool? ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant az_ = @this?.IssuedElement;
				DateTimeOffset? ba_ = az_?.Value;
				CqlDateTime bb_ = context.Operators.Convert<CqlDateTime>(ba_);
				CqlDateTime bc_ = qiCoreCommon_2_0_000.earliest(context, bb_ as object);

				return bc_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = fhirHelpers_4_3_000.ToValue(context, m_);
			IEnumerable<Observation> p_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? q_(Observation WhiteBloodCellLab)
			{
				Instant bd_ = WhiteBloodCellLab?.IssuedElement;
				DateTimeOffset? be_ = bd_?.Value;
				CqlDateTime bf_ = context.Operators.Convert<CqlDateTime>(be_);
				CqlDateTime bg_ = qiCoreCommon_2_0_000.earliest(context, bf_ as object);
				Period bh_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bi_ = fhirHelpers_4_3_000.ToInterval(context, bh_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlQuantity bk_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bl_ = context.Operators.Subtract(bj_, bk_);
				CqlInterval<CqlDateTime> bn_ = fhirHelpers_4_3_000.ToInterval(context, bh_);
				CqlDateTime bo_ = context.Operators.Start(bn_);
				CqlDateTime bq_ = context.Operators.Add(bo_, bk_);
				CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bl_, bq_, true, true);
				bool? bs_ = context.Operators.In<CqlDateTime>(bg_, br_, default);
				Code<ObservationStatus> bt_ = WhiteBloodCellLab?.StatusElement;
				ObservationStatus? bu_ = bt_?.Value;
				string bv_ = context.Operators.Convert<string>(bu_);
				string[] bw_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bx_ = context.Operators.In<string>(bv_, bw_ as IEnumerable<string>);
				bool? by_ = context.Operators.And(bs_, bx_);
				DataType bz_ = WhiteBloodCellLab?.Value;
				object ca_ = fhirHelpers_4_3_000.ToValue(context, bz_);
				bool? cb_ = context.Operators.Not((bool?)(ca_ is null));
				bool? cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			IEnumerable<Observation> r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				Instant cd_ = @this?.IssuedElement;
				DateTimeOffset? ce_ = cd_?.Value;
				CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
				CqlDateTime cg_ = qiCoreCommon_2_0_000.earliest(context, cf_ as object);

				return cg_;
			};
			IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Observation u_ = context.Operators.First<Observation>(t_);
			Instant v_ = u_?.IssuedElement;
			DateTimeOffset? w_ = v_?.Value;
			CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
			(string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? y_ = (e_, n_ as CqlQuantity, x_);

			return y_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = supplementalDataElements_3_4_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = supplementalDataElements_3_4_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = supplementalDataElements_3_4_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = supplementalDataElements_3_4_000.SDE_Sex(context);

		return a_;
	}

}
