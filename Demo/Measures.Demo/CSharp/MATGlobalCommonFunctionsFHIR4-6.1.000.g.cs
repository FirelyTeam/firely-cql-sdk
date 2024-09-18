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

#pragma warning disable CS9113 // Parameter is unread.

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("MATGlobalCommonFunctionsFHIR4", "6.1.000")]
public class MATGlobalCommonFunctionsFHIR4_6_1_000(
    FHIRHelpers_4_0_001 _FHIRHelpers_4_0_001)
{

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public  CqlValueSet Emergency_Department_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public  CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public  CqlValueSet Observation_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);

    [CqlDeclaration("Present on Admission or Clinically Undetermined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197")]
	public  CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", default);

    [CqlDeclaration("active")]
	public  CqlCode active(CqlContext context) => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("allergy-active")]
	public  CqlCode allergy_active(CqlContext context) => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlDeclaration("allergy-confirmed")]
	public  CqlCode allergy_confirmed(CqlContext context) => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlDeclaration("allergy-inactive")]
	public  CqlCode allergy_inactive(CqlContext context) => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlDeclaration("allergy-refuted")]
	public  CqlCode allergy_refuted(CqlContext context) => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlDeclaration("allergy-resolved")]
	public  CqlCode allergy_resolved(CqlContext context) => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlDeclaration("allergy-unconfirmed")]
	public  CqlCode allergy_unconfirmed(CqlContext context) => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlDeclaration("Billing")]
	public  CqlCode Billing(CqlContext context) => 
		new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlDeclaration("Birthdate")]
	public  CqlCode Birthdate(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Community")]
	public  CqlCode Community(CqlContext context) => 
		new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlDeclaration("confirmed")]
	public  CqlCode confirmed(CqlContext context) => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("Dead")]
	public  CqlCode Dead(CqlContext context) => 
		new CqlCode("419099009", "http://snomed.info/sct", default, default);

    [CqlDeclaration("differential")]
	public  CqlCode differential(CqlContext context) => 
		new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("Discharge")]
	public  CqlCode Discharge(CqlContext context) => 
		new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlDeclaration("entered-in-error")]
	public  CqlCode entered_in_error(CqlContext context) => 
		new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("ER")]
	public  CqlCode ER(CqlContext context) => 
		new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);

    [CqlDeclaration("ICU")]
	public  CqlCode ICU(CqlContext context) => 
		new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);

    [CqlDeclaration("inactive")]
	public  CqlCode inactive(CqlContext context) => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("provisional")]
	public  CqlCode provisional(CqlContext context) => 
		new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("recurrence")]
	public  CqlCode recurrence(CqlContext context) => 
		new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("refuted")]
	public  CqlCode refuted(CqlContext context) => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("relapse")]
	public  CqlCode relapse(CqlContext context) => 
		new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("remission")]
	public  CqlCode remission(CqlContext context) => 
		new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("resolved")]
	public  CqlCode resolved(CqlContext context) => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("unconfirmed")]
	public  CqlCode unconfirmed(CqlContext context) => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("ConditionClinicalStatusCodes")]
	public  CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
		];

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceClinicalStatusCodes")]
	public  CqlCode[] AllergyIntoleranceClinicalStatusCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
			new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
			new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
		];

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
	public  CqlCode[] AllergyIntoleranceVerificationStatusCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Diagnosis Role")]
	public  CqlCode[] Diagnosis_Role(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public  CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("MedicationRequestCategory")]
	public  CqlCode[] MedicationRequestCategory(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
			new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ConditionVerificationStatusCodes")]
	public  CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public  CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("419099009", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("RoleCode")]
	public  CqlCode[] RoleCode(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
			new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("LengthInDays")]
	public  int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
	{
		CqlDateTime a_ = context.Operators.Start(Value);
		CqlDateTime b_ = context.Operators.End(Value);
		int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

    [CqlDeclaration("Inpatient Encounter")]
	public  IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
	{
		CqlValueSet a_ = this.Encounter_Inpatient(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter EncounterInpatient)
		{
			Code<Encounter.EncounterStatus> e_ = EncounterInpatient?.StatusElement;
			string f_ = _FHIRHelpers_4_0_001.ToString(context, e_);
			bool? g_ = context.Operators.Equal(f_, "finished");
			Period h_ = EncounterInpatient?.Period;
			CqlInterval<CqlDateTime> i_ = _FHIRHelpers_4_0_001.ToInterval(context, h_);
			int? j_ = this.LengthInDays(context, i_);
			bool? k_ = context.Operators.LessOrEqual(j_, 120);
			bool? l_ = context.Operators.And(g_, k_);
			CqlInterval<CqlDateTime> n_ = _FHIRHelpers_4_0_001.ToInterval(context, h_);
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
			bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, default);
			bool? r_ = context.Operators.And(l_, q_);

			return r_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("ED Visit")]
	public  Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
	{
		CqlValueSet a_ = this.Emergency_Department_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter EDVisit)
		{
			Code<Encounter.EncounterStatus> h_ = EDVisit?.StatusElement;
			string i_ = _FHIRHelpers_4_0_001.ToString(context, h_);
			bool? j_ = context.Operators.Equal(i_, "finished");
			Period k_ = EDVisit?.Period;
			CqlInterval<CqlDateTime> l_ = _FHIRHelpers_4_0_001.ToInterval(context, k_);
			CqlDateTime m_ = context.Operators.End(l_);
			Period n_ = TheEncounter?.Period;
			CqlInterval<CqlDateTime> o_ = _FHIRHelpers_4_0_001.ToInterval(context, n_);
			CqlDateTime p_ = context.Operators.Start(o_);
			CqlQuantity q_ = context.Operators.Quantity(1m, "hour");
			CqlDateTime r_ = context.Operators.Subtract(p_, q_);
			CqlInterval<CqlDateTime> t_ = _FHIRHelpers_4_0_001.ToInterval(context, n_);
			CqlDateTime u_ = context.Operators.Start(t_);
			CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, true);
			bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, default);
			CqlInterval<CqlDateTime> y_ = _FHIRHelpers_4_0_001.ToInterval(context, n_);
			CqlDateTime z_ = context.Operators.Start(y_);
			bool? aa_ = context.Operators.Not((bool?)(z_ is null));
			bool? ab_ = context.Operators.And(w_, aa_);
			bool? ac_ = context.Operators.And(j_, ab_);

			return ac_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			Period ad_ = @this?.Period;
			CqlInterval<CqlDateTime> ae_ = _FHIRHelpers_4_0_001.ToInterval(context, ad_);
			CqlDateTime af_ = context.Operators.End(ae_);

			return af_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter g_ = context.Operators.Last<Encounter>(f_);

		return g_;
	}

    [CqlDeclaration("Hospitalization")]
	public  CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
	{
		Encounter a_ = this.ED_Visit(context, TheEncounter);
		Encounter[] b_ = [
			a_,
		];
		CqlInterval<CqlDateTime> c_(Encounter X)
		{
			CqlInterval<CqlDateTime> f_()
			{
				if (X is null)
				{
					Period g_ = TheEncounter?.Period;
					CqlInterval<CqlDateTime> h_ = _FHIRHelpers_4_0_001.ToInterval(context, g_);

					return h_;
				}
				else
				{
					Period i_ = X?.Period;
					CqlInterval<CqlDateTime> j_ = _FHIRHelpers_4_0_001.ToInterval(context, i_);
					CqlDateTime k_ = context.Operators.Start(j_);
					Period l_ = TheEncounter?.Period;
					CqlInterval<CqlDateTime> m_ = _FHIRHelpers_4_0_001.ToInterval(context, l_);
					CqlDateTime n_ = context.Operators.End(m_);
					CqlInterval<CqlDateTime> o_ = context.Operators.Interval(k_, n_, true, true);

					return o_;
				}
			};

			return f_();
		};
		IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
		CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

		return e_;
	}

    [CqlDeclaration("Hospitalization Locations")]
	public  IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
	{
		Encounter a_ = this.ED_Visit(context, TheEncounter);
		Encounter[] b_ = [
			a_,
		];
		IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
		{
			IEnumerable<Encounter.LocationComponent> f_()
			{
				if (EDEncounter is null)
				{
					List<Encounter.LocationComponent> g_ = TheEncounter?.Location;

					return (IEnumerable<Encounter.LocationComponent>)g_;
				}
				else
				{
					List<Encounter.LocationComponent> h_ = EDEncounter?.Location;
					List<Encounter.LocationComponent> i_ = TheEncounter?.Location;
					IEnumerable<Encounter.LocationComponent>[] j_ = [
						(IEnumerable<Encounter.LocationComponent>)h_,
						(IEnumerable<Encounter.LocationComponent>)i_,
					];
					IEnumerable<Encounter.LocationComponent> k_ = context.Operators.Flatten<Encounter.LocationComponent>(j_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

					return k_;
				}
			};

			return f_();
		};
		IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
		IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);

		return e_;
	}

    [CqlDeclaration("Hospitalization Length of Stay")]
	public  int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.Hospitalization(context, TheEncounter);
		int? b_ = this.LengthInDays(context, a_);

		return b_;
	}

    [CqlDeclaration("Hospital Admission Time")]
	public  CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.Hospitalization(context, TheEncounter);
		CqlDateTime b_ = context.Operators.Start(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Discharge Time")]
	public  CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
	{
		Period a_ = TheEncounter?.Period;
		CqlInterval<CqlDateTime> b_ = _FHIRHelpers_4_0_001.ToInterval(context, a_);
		CqlDateTime c_ = context.Operators.End(b_);

		return c_;
	}

    [CqlDeclaration("Hospital Arrival Time")]
	public  CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(context, TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			Period h_ = @this?.Period;
			CqlInterval<CqlDateTime> i_ = _FHIRHelpers_4_0_001.ToInterval(context, h_);
			CqlDateTime j_ = context.Operators.Start(i_);

			return j_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent d_ = context.Operators.First<Encounter.LocationComponent>(c_);
		Period e_ = d_?.Period;
		CqlInterval<CqlDateTime> f_ = _FHIRHelpers_4_0_001.ToInterval(context, e_);
		CqlDateTime g_ = context.Operators.Start(f_);

		return g_;
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
				CqlInterval<CqlDateTime> ag_ = _FHIRHelpers_4_0_001.ToInterval(context, af_);
				CqlDateTime ah_ = context.Operators.End(ag_);
				CqlValueSet ai_ = this.Observation_Services(context);
				IEnumerable<Encounter> aj_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, default);
				bool? ak_(Encounter LastObs)
				{
					Period cb_ = LastObs?.Period;
					CqlInterval<CqlDateTime> cc_ = _FHIRHelpers_4_0_001.ToInterval(context, cb_);
					CqlDateTime cd_ = context.Operators.End(cc_);
					Period ce_ = Visit?.Period;
					CqlInterval<CqlDateTime> cf_ = _FHIRHelpers_4_0_001.ToInterval(context, ce_);
					CqlDateTime cg_ = context.Operators.Start(cf_);
					CqlQuantity ch_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ci_ = context.Operators.Subtract(cg_, ch_);
					CqlInterval<CqlDateTime> ck_ = _FHIRHelpers_4_0_001.ToInterval(context, ce_);
					CqlDateTime cl_ = context.Operators.Start(ck_);
					CqlInterval<CqlDateTime> cm_ = context.Operators.Interval(ci_, cl_, true, true);
					bool? cn_ = context.Operators.In<CqlDateTime>(cd_, cm_, default);
					CqlInterval<CqlDateTime> cp_ = _FHIRHelpers_4_0_001.ToInterval(context, ce_);
					CqlDateTime cq_ = context.Operators.Start(cp_);
					bool? cr_ = context.Operators.Not((bool?)(cq_ is null));
					bool? cs_ = context.Operators.And(cn_, cr_);

					return cs_;
				};
				IEnumerable<Encounter> al_ = context.Operators.Where<Encounter>(aj_, ak_);
				object am_(Encounter @this)
				{
					Period ct_ = @this?.Period;
					CqlInterval<CqlDateTime> cu_ = _FHIRHelpers_4_0_001.ToInterval(context, ct_);
					CqlDateTime cv_ = context.Operators.End(cu_);

					return cv_;
				};
				IEnumerable<Encounter> an_ = context.Operators.SortBy<Encounter>(al_, am_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ao_ = context.Operators.Last<Encounter>(an_);
				Period ap_ = ao_?.Period;
				CqlInterval<CqlDateTime> aq_ = _FHIRHelpers_4_0_001.ToInterval(context, ap_);
				CqlDateTime ar_ = context.Operators.Start(aq_);
				Period as_ = Visit?.Period;
				CqlInterval<CqlDateTime> at_ = _FHIRHelpers_4_0_001.ToInterval(context, as_);
				CqlDateTime au_ = context.Operators.Start(at_);
				CqlQuantity av_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime aw_ = context.Operators.Subtract(ar_ ?? au_, av_);
				IEnumerable<Encounter> ay_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, default);
				bool? az_(Encounter LastObs)
				{
					Period cw_ = LastObs?.Period;
					CqlInterval<CqlDateTime> cx_ = _FHIRHelpers_4_0_001.ToInterval(context, cw_);
					CqlDateTime cy_ = context.Operators.End(cx_);
					Period cz_ = Visit?.Period;
					CqlInterval<CqlDateTime> da_ = _FHIRHelpers_4_0_001.ToInterval(context, cz_);
					CqlDateTime db_ = context.Operators.Start(da_);
					CqlQuantity dc_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dd_ = context.Operators.Subtract(db_, dc_);
					CqlInterval<CqlDateTime> df_ = _FHIRHelpers_4_0_001.ToInterval(context, cz_);
					CqlDateTime dg_ = context.Operators.Start(df_);
					CqlInterval<CqlDateTime> dh_ = context.Operators.Interval(dd_, dg_, true, true);
					bool? di_ = context.Operators.In<CqlDateTime>(cy_, dh_, default);
					CqlInterval<CqlDateTime> dk_ = _FHIRHelpers_4_0_001.ToInterval(context, cz_);
					CqlDateTime dl_ = context.Operators.Start(dk_);
					bool? dm_ = context.Operators.Not((bool?)(dl_ is null));
					bool? dn_ = context.Operators.And(di_, dm_);

					return dn_;
				};
				IEnumerable<Encounter> ba_ = context.Operators.Where<Encounter>(ay_, az_);
				object bb_(Encounter @this)
				{
					Period do_ = @this?.Period;
					CqlInterval<CqlDateTime> dp_ = _FHIRHelpers_4_0_001.ToInterval(context, do_);
					CqlDateTime dq_ = context.Operators.End(dp_);

					return dq_;
				};
				IEnumerable<Encounter> bc_ = context.Operators.SortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bd_ = context.Operators.Last<Encounter>(bc_);
				Period be_ = bd_?.Period;
				CqlInterval<CqlDateTime> bf_ = _FHIRHelpers_4_0_001.ToInterval(context, be_);
				CqlDateTime bg_ = context.Operators.Start(bf_);
				CqlInterval<CqlDateTime> bi_ = _FHIRHelpers_4_0_001.ToInterval(context, as_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlInterval<CqlDateTime> bk_ = context.Operators.Interval(aw_, bg_ ?? bj_, true, true);
				bool? bl_ = context.Operators.In<CqlDateTime>(ah_, bk_, default);
				IEnumerable<Encounter> bn_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, default);
				bool? bo_(Encounter LastObs)
				{
					Period dr_ = LastObs?.Period;
					CqlInterval<CqlDateTime> ds_ = _FHIRHelpers_4_0_001.ToInterval(context, dr_);
					CqlDateTime dt_ = context.Operators.End(ds_);
					Period du_ = Visit?.Period;
					CqlInterval<CqlDateTime> dv_ = _FHIRHelpers_4_0_001.ToInterval(context, du_);
					CqlDateTime dw_ = context.Operators.Start(dv_);
					CqlQuantity dx_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dy_ = context.Operators.Subtract(dw_, dx_);
					CqlInterval<CqlDateTime> ea_ = _FHIRHelpers_4_0_001.ToInterval(context, du_);
					CqlDateTime eb_ = context.Operators.Start(ea_);
					CqlInterval<CqlDateTime> ec_ = context.Operators.Interval(dy_, eb_, true, true);
					bool? ed_ = context.Operators.In<CqlDateTime>(dt_, ec_, default);
					CqlInterval<CqlDateTime> ef_ = _FHIRHelpers_4_0_001.ToInterval(context, du_);
					CqlDateTime eg_ = context.Operators.Start(ef_);
					bool? eh_ = context.Operators.Not((bool?)(eg_ is null));
					bool? ei_ = context.Operators.And(ed_, eh_);

					return ei_;
				};
				IEnumerable<Encounter> bp_ = context.Operators.Where<Encounter>(bn_, bo_);
				object bq_(Encounter @this)
				{
					Period ej_ = @this?.Period;
					CqlInterval<CqlDateTime> ek_ = _FHIRHelpers_4_0_001.ToInterval(context, ej_);
					CqlDateTime el_ = context.Operators.End(ek_);

					return el_;
				};
				IEnumerable<Encounter> br_ = context.Operators.SortBy<Encounter>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bs_ = context.Operators.Last<Encounter>(br_);
				Period bt_ = bs_?.Period;
				CqlInterval<CqlDateTime> bu_ = _FHIRHelpers_4_0_001.ToInterval(context, bt_);
				CqlDateTime bv_ = context.Operators.Start(bu_);
				CqlInterval<CqlDateTime> bx_ = _FHIRHelpers_4_0_001.ToInterval(context, as_);
				CqlDateTime by_ = context.Operators.Start(bx_);
				bool? bz_ = context.Operators.Not((bool?)((bv_ ?? by_) is null));
				bool? ca_ = context.Operators.And(bl_, bz_);

				return ca_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				Period em_ = @this?.Period;
				CqlInterval<CqlDateTime> en_ = _FHIRHelpers_4_0_001.ToInterval(context, em_);
				CqlDateTime eo_ = context.Operators.End(en_);

				return eo_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			Period l_ = k_?.Period;
			CqlInterval<CqlDateTime> m_ = _FHIRHelpers_4_0_001.ToInterval(context, l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlValueSet o_ = this.Observation_Services(context);
			IEnumerable<Encounter> p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, default);
			bool? q_(Encounter LastObs)
			{
				Period ep_ = LastObs?.Period;
				CqlInterval<CqlDateTime> eq_ = _FHIRHelpers_4_0_001.ToInterval(context, ep_);
				CqlDateTime er_ = context.Operators.End(eq_);
				Period es_ = Visit?.Period;
				CqlInterval<CqlDateTime> et_ = _FHIRHelpers_4_0_001.ToInterval(context, es_);
				CqlDateTime eu_ = context.Operators.Start(et_);
				CqlQuantity ev_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ew_ = context.Operators.Subtract(eu_, ev_);
				CqlInterval<CqlDateTime> ey_ = _FHIRHelpers_4_0_001.ToInterval(context, es_);
				CqlDateTime ez_ = context.Operators.Start(ey_);
				CqlInterval<CqlDateTime> fa_ = context.Operators.Interval(ew_, ez_, true, true);
				bool? fb_ = context.Operators.In<CqlDateTime>(er_, fa_, default);
				CqlInterval<CqlDateTime> fd_ = _FHIRHelpers_4_0_001.ToInterval(context, es_);
				CqlDateTime fe_ = context.Operators.Start(fd_);
				bool? ff_ = context.Operators.Not((bool?)(fe_ is null));
				bool? fg_ = context.Operators.And(fb_, ff_);

				return fg_;
			};
			IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				Period fh_ = @this?.Period;
				CqlInterval<CqlDateTime> fi_ = _FHIRHelpers_4_0_001.ToInterval(context, fh_);
				CqlDateTime fj_ = context.Operators.End(fi_);

				return fj_;
			};
			IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter u_ = context.Operators.Last<Encounter>(t_);
			Period v_ = u_?.Period;
			CqlInterval<CqlDateTime> w_ = _FHIRHelpers_4_0_001.ToInterval(context, v_);
			CqlDateTime x_ = context.Operators.Start(w_);
			Period y_ = Visit?.Period;
			CqlInterval<CqlDateTime> z_ = _FHIRHelpers_4_0_001.ToInterval(context, y_);
			CqlDateTime aa_ = context.Operators.Start(z_);
			CqlInterval<CqlDateTime> ac_ = _FHIRHelpers_4_0_001.ToInterval(context, y_);
			CqlDateTime ad_ = context.Operators.End(ac_);
			CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ad_, true, true);

			return ae_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("Normalize Interval")]
	public  CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (choice is FhirDateTime)
			{
				CqlDateTime b_ = _FHIRHelpers_4_0_001.ToDateTime(context, choice as FhirDateTime);
				CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (choice is Period)
			{
				CqlInterval<CqlDateTime> e_ = _FHIRHelpers_4_0_001.ToInterval(context, choice as Period);

				return e_;
			}
			else if (choice is Instant)
			{
				CqlDateTime f_ = _FHIRHelpers_4_0_001.ToDateTime(context, choice as Instant);
				CqlInterval<CqlDateTime> h_ = context.Operators.Interval(f_, f_, true, true);

				return h_;
			}
			else if (choice is Age)
			{
				Patient i_ = this.Patient(context);
				Date j_ = i_?.BirthDateElement;
				CqlDate k_ = _FHIRHelpers_4_0_001.ToDate(context, j_);
				CqlQuantity l_ = _FHIRHelpers_4_0_001.ToQuantity(context, choice as Age);
				CqlDate m_ = context.Operators.Add(k_, l_);
				Date o_ = i_?.BirthDateElement;
				CqlDate p_ = _FHIRHelpers_4_0_001.ToDate(context, o_);
				CqlDate r_ = context.Operators.Add(p_, l_);
				CqlQuantity s_ = context.Operators.Quantity(1m, "year");
				CqlDate t_ = context.Operators.Add(r_, s_);
				CqlInterval<CqlDate> u_ = context.Operators.Interval(m_, t_, true, false);
				CqlDate v_ = u_?.low;
				CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
				Date y_ = i_?.BirthDateElement;
				CqlDate z_ = _FHIRHelpers_4_0_001.ToDate(context, y_);
				CqlDate ab_ = context.Operators.Add(z_, l_);
				Date ad_ = i_?.BirthDateElement;
				CqlDate ae_ = _FHIRHelpers_4_0_001.ToDate(context, ad_);
				CqlDate ag_ = context.Operators.Add(ae_, l_);
				CqlDate ai_ = context.Operators.Add(ag_, s_);
				CqlInterval<CqlDate> aj_ = context.Operators.Interval(ab_, ai_, true, false);
				CqlDate ak_ = aj_?.high;
				CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
				Date an_ = i_?.BirthDateElement;
				CqlDate ao_ = _FHIRHelpers_4_0_001.ToDate(context, an_);
				CqlDate aq_ = context.Operators.Add(ao_, l_);
				Date as_ = i_?.BirthDateElement;
				CqlDate at_ = _FHIRHelpers_4_0_001.ToDate(context, as_);
				CqlDate av_ = context.Operators.Add(at_, l_);
				CqlDate ax_ = context.Operators.Add(av_, s_);
				CqlInterval<CqlDate> ay_ = context.Operators.Interval(aq_, ax_, true, false);
				bool? az_ = ay_?.lowClosed;
				Date bb_ = i_?.BirthDateElement;
				CqlDate bc_ = _FHIRHelpers_4_0_001.ToDate(context, bb_);
				CqlDate be_ = context.Operators.Add(bc_, l_);
				Date bg_ = i_?.BirthDateElement;
				CqlDate bh_ = _FHIRHelpers_4_0_001.ToDate(context, bg_);
				CqlDate bj_ = context.Operators.Add(bh_, l_);
				CqlDate bl_ = context.Operators.Add(bj_, s_);
				CqlInterval<CqlDate> bm_ = context.Operators.Interval(be_, bl_, true, false);
				bool? bn_ = bm_?.highClosed;
				CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(w_, al_, az_, bn_);

				return bo_;
			}
			else if (choice is Range)
			{
				Patient bp_ = this.Patient(context);
				Date bq_ = bp_?.BirthDateElement;
				CqlDate br_ = _FHIRHelpers_4_0_001.ToDate(context, bq_);
				Quantity bs_ = (choice as Range)?.Low;
				CqlQuantity bt_ = _FHIRHelpers_4_0_001.ToQuantity(context, bs_);
				CqlDate bu_ = context.Operators.Add(br_, bt_);
				Date bw_ = bp_?.BirthDateElement;
				CqlDate bx_ = _FHIRHelpers_4_0_001.ToDate(context, bw_);
				Quantity by_ = (choice as Range)?.High;
				CqlQuantity bz_ = _FHIRHelpers_4_0_001.ToQuantity(context, by_);
				CqlDate ca_ = context.Operators.Add(bx_, bz_);
				CqlQuantity cb_ = context.Operators.Quantity(1m, "year");
				CqlDate cc_ = context.Operators.Add(ca_, cb_);
				CqlInterval<CqlDate> cd_ = context.Operators.Interval(bu_, cc_, true, false);
				CqlDate ce_ = cd_?.low;
				CqlDateTime cf_ = context.Operators.ConvertDateToDateTime(ce_);
				Date ch_ = bp_?.BirthDateElement;
				CqlDate ci_ = _FHIRHelpers_4_0_001.ToDate(context, ch_);
				CqlQuantity ck_ = _FHIRHelpers_4_0_001.ToQuantity(context, bs_);
				CqlDate cl_ = context.Operators.Add(ci_, ck_);
				Date cn_ = bp_?.BirthDateElement;
				CqlDate co_ = _FHIRHelpers_4_0_001.ToDate(context, cn_);
				CqlQuantity cq_ = _FHIRHelpers_4_0_001.ToQuantity(context, by_);
				CqlDate cr_ = context.Operators.Add(co_, cq_);
				CqlDate ct_ = context.Operators.Add(cr_, cb_);
				CqlInterval<CqlDate> cu_ = context.Operators.Interval(cl_, ct_, true, false);
				CqlDate cv_ = cu_?.high;
				CqlDateTime cw_ = context.Operators.ConvertDateToDateTime(cv_);
				Date cy_ = bp_?.BirthDateElement;
				CqlDate cz_ = _FHIRHelpers_4_0_001.ToDate(context, cy_);
				CqlQuantity db_ = _FHIRHelpers_4_0_001.ToQuantity(context, bs_);
				CqlDate dc_ = context.Operators.Add(cz_, db_);
				Date de_ = bp_?.BirthDateElement;
				CqlDate df_ = _FHIRHelpers_4_0_001.ToDate(context, de_);
				CqlQuantity dh_ = _FHIRHelpers_4_0_001.ToQuantity(context, by_);
				CqlDate di_ = context.Operators.Add(df_, dh_);
				CqlDate dk_ = context.Operators.Add(di_, cb_);
				CqlInterval<CqlDate> dl_ = context.Operators.Interval(dc_, dk_, true, false);
				bool? dm_ = dl_?.lowClosed;
				Date do_ = bp_?.BirthDateElement;
				CqlDate dp_ = _FHIRHelpers_4_0_001.ToDate(context, do_);
				CqlQuantity dr_ = _FHIRHelpers_4_0_001.ToQuantity(context, bs_);
				CqlDate ds_ = context.Operators.Add(dp_, dr_);
				Date du_ = bp_?.BirthDateElement;
				CqlDate dv_ = _FHIRHelpers_4_0_001.ToDate(context, du_);
				CqlQuantity dx_ = _FHIRHelpers_4_0_001.ToQuantity(context, by_);
				CqlDate dy_ = context.Operators.Add(dv_, dx_);
				CqlDate ea_ = context.Operators.Add(dy_, cb_);
				CqlInterval<CqlDate> eb_ = context.Operators.Interval(ds_, ea_, true, false);
				bool? ec_ = eb_?.highClosed;
				CqlInterval<CqlDateTime> ed_ = context.Operators.Interval(cf_, cw_, dm_, ec_);

				return ed_;
			}
			else if (choice is Timing)
			{
				CqlInterval<CqlDateTime> ee_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

				return ee_;
			}
			else if (choice is FhirString)
			{
				CqlInterval<CqlDateTime> ef_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

				return ef_;
			}
			else
			{
				return null as CqlInterval<CqlDateTime>;
			}
		};

		return a_();
	}

    [CqlDeclaration("Normalize Abatement")]
	public  CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, Condition condition)
	{
		CqlInterval<CqlDateTime> a_()
		{
			bool b_()
			{
				DataType h_ = condition?.Abatement;
				bool i_ = h_ is FhirDateTime;

				return i_;
			};
			bool c_()
			{
				DataType j_ = condition?.Abatement;
				bool k_ = j_ is Period;

				return k_;
			};
			bool d_()
			{
				DataType l_ = condition?.Abatement;
				bool m_ = l_ is FhirString;

				return m_;
			};
			bool e_()
			{
				DataType n_ = condition?.Abatement;
				bool o_ = n_ is Age;

				return o_;
			};
			bool f_()
			{
				DataType p_ = condition?.Abatement;
				bool q_ = p_ is Range;

				return q_;
			};
			bool g_()
			{
				DataType r_ = condition?.Abatement;
				bool s_ = r_ is FhirBoolean;

				return s_;
			};
			if (b_())
			{
				DataType t_ = condition?.Abatement;
				CqlDateTime u_ = _FHIRHelpers_4_0_001.ToDateTime(context, t_ as FhirDateTime);
				CqlDateTime w_ = _FHIRHelpers_4_0_001.ToDateTime(context, t_ as FhirDateTime);
				CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);

				return x_;
			}
			else if (c_())
			{
				DataType y_ = condition?.Abatement;
				CqlInterval<CqlDateTime> z_ = _FHIRHelpers_4_0_001.ToInterval(context, y_ as Period);

				return z_;
			}
			else if (d_())
			{
				CqlInterval<CqlDateTime> aa_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

				return aa_;
			}
			else if (e_())
			{
				Patient ab_ = this.Patient(context);
				Date ac_ = ab_?.BirthDateElement;
				CqlDate ad_ = _FHIRHelpers_4_0_001.ToDate(context, ac_);
				DataType ae_ = condition?.Abatement;
				CqlQuantity af_ = _FHIRHelpers_4_0_001.ToQuantity(context, ae_ as Age);
				CqlDate ag_ = context.Operators.Add(ad_, af_);
				Date ai_ = ab_?.BirthDateElement;
				CqlDate aj_ = _FHIRHelpers_4_0_001.ToDate(context, ai_);
				CqlQuantity al_ = _FHIRHelpers_4_0_001.ToQuantity(context, ae_ as Age);
				CqlDate am_ = context.Operators.Add(aj_, al_);
				CqlQuantity an_ = context.Operators.Quantity(1m, "year");
				CqlDate ao_ = context.Operators.Add(am_, an_);
				CqlInterval<CqlDate> ap_ = context.Operators.Interval(ag_, ao_, true, false);
				CqlDate aq_ = ap_?.low;
				CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
				Date at_ = ab_?.BirthDateElement;
				CqlDate au_ = _FHIRHelpers_4_0_001.ToDate(context, at_);
				CqlQuantity aw_ = _FHIRHelpers_4_0_001.ToQuantity(context, ae_ as Age);
				CqlDate ax_ = context.Operators.Add(au_, aw_);
				Date az_ = ab_?.BirthDateElement;
				CqlDate ba_ = _FHIRHelpers_4_0_001.ToDate(context, az_);
				CqlQuantity bc_ = _FHIRHelpers_4_0_001.ToQuantity(context, ae_ as Age);
				CqlDate bd_ = context.Operators.Add(ba_, bc_);
				CqlDate bf_ = context.Operators.Add(bd_, an_);
				CqlInterval<CqlDate> bg_ = context.Operators.Interval(ax_, bf_, true, false);
				CqlDate bh_ = bg_?.high;
				CqlDateTime bi_ = context.Operators.ConvertDateToDateTime(bh_);
				Date bk_ = ab_?.BirthDateElement;
				CqlDate bl_ = _FHIRHelpers_4_0_001.ToDate(context, bk_);
				CqlQuantity bn_ = _FHIRHelpers_4_0_001.ToQuantity(context, ae_ as Age);
				CqlDate bo_ = context.Operators.Add(bl_, bn_);
				Date bq_ = ab_?.BirthDateElement;
				CqlDate br_ = _FHIRHelpers_4_0_001.ToDate(context, bq_);
				CqlQuantity bt_ = _FHIRHelpers_4_0_001.ToQuantity(context, ae_ as Age);
				CqlDate bu_ = context.Operators.Add(br_, bt_);
				CqlDate bw_ = context.Operators.Add(bu_, an_);
				CqlInterval<CqlDate> bx_ = context.Operators.Interval(bo_, bw_, true, false);
				bool? by_ = bx_?.lowClosed;
				Date ca_ = ab_?.BirthDateElement;
				CqlDate cb_ = _FHIRHelpers_4_0_001.ToDate(context, ca_);
				CqlQuantity cd_ = _FHIRHelpers_4_0_001.ToQuantity(context, ae_ as Age);
				CqlDate ce_ = context.Operators.Add(cb_, cd_);
				Date cg_ = ab_?.BirthDateElement;
				CqlDate ch_ = _FHIRHelpers_4_0_001.ToDate(context, cg_);
				CqlQuantity cj_ = _FHIRHelpers_4_0_001.ToQuantity(context, ae_ as Age);
				CqlDate ck_ = context.Operators.Add(ch_, cj_);
				CqlDate cm_ = context.Operators.Add(ck_, an_);
				CqlInterval<CqlDate> cn_ = context.Operators.Interval(ce_, cm_, true, false);
				bool? co_ = cn_?.highClosed;
				CqlInterval<CqlDateTime> cp_ = context.Operators.Interval(ar_, bi_, by_, co_);

				return cp_;
			}
			else if (f_())
			{
				Patient cq_ = this.Patient(context);
				Date cr_ = cq_?.BirthDateElement;
				CqlDate cs_ = _FHIRHelpers_4_0_001.ToDate(context, cr_);
				DataType ct_ = condition?.Abatement;
				Quantity cu_ = (ct_ as Range)?.Low;
				CqlQuantity cv_ = _FHIRHelpers_4_0_001.ToQuantity(context, cu_);
				CqlDate cw_ = context.Operators.Add(cs_, cv_);
				Date cy_ = cq_?.BirthDateElement;
				CqlDate cz_ = _FHIRHelpers_4_0_001.ToDate(context, cy_);
				Quantity db_ = (ct_ as Range)?.High;
				CqlQuantity dc_ = _FHIRHelpers_4_0_001.ToQuantity(context, db_);
				CqlDate dd_ = context.Operators.Add(cz_, dc_);
				CqlQuantity de_ = context.Operators.Quantity(1m, "year");
				CqlDate df_ = context.Operators.Add(dd_, de_);
				CqlInterval<CqlDate> dg_ = context.Operators.Interval(cw_, df_, true, false);
				CqlDate dh_ = dg_?.low;
				CqlDateTime di_ = context.Operators.ConvertDateToDateTime(dh_);
				Date dk_ = cq_?.BirthDateElement;
				CqlDate dl_ = _FHIRHelpers_4_0_001.ToDate(context, dk_);
				Quantity dn_ = (ct_ as Range)?.Low;
				CqlQuantity do_ = _FHIRHelpers_4_0_001.ToQuantity(context, dn_);
				CqlDate dp_ = context.Operators.Add(dl_, do_);
				Date dr_ = cq_?.BirthDateElement;
				CqlDate ds_ = _FHIRHelpers_4_0_001.ToDate(context, dr_);
				Quantity du_ = (ct_ as Range)?.High;
				CqlQuantity dv_ = _FHIRHelpers_4_0_001.ToQuantity(context, du_);
				CqlDate dw_ = context.Operators.Add(ds_, dv_);
				CqlDate dy_ = context.Operators.Add(dw_, de_);
				CqlInterval<CqlDate> dz_ = context.Operators.Interval(dp_, dy_, true, false);
				CqlDate ea_ = dz_?.high;
				CqlDateTime eb_ = context.Operators.ConvertDateToDateTime(ea_);
				Date ed_ = cq_?.BirthDateElement;
				CqlDate ee_ = _FHIRHelpers_4_0_001.ToDate(context, ed_);
				Quantity eg_ = (ct_ as Range)?.Low;
				CqlQuantity eh_ = _FHIRHelpers_4_0_001.ToQuantity(context, eg_);
				CqlDate ei_ = context.Operators.Add(ee_, eh_);
				Date ek_ = cq_?.BirthDateElement;
				CqlDate el_ = _FHIRHelpers_4_0_001.ToDate(context, ek_);
				Quantity en_ = (ct_ as Range)?.High;
				CqlQuantity eo_ = _FHIRHelpers_4_0_001.ToQuantity(context, en_);
				CqlDate ep_ = context.Operators.Add(el_, eo_);
				CqlDate er_ = context.Operators.Add(ep_, de_);
				CqlInterval<CqlDate> es_ = context.Operators.Interval(ei_, er_, true, false);
				bool? et_ = es_?.lowClosed;
				Date ev_ = cq_?.BirthDateElement;
				CqlDate ew_ = _FHIRHelpers_4_0_001.ToDate(context, ev_);
				Quantity ey_ = (ct_ as Range)?.Low;
				CqlQuantity ez_ = _FHIRHelpers_4_0_001.ToQuantity(context, ey_);
				CqlDate fa_ = context.Operators.Add(ew_, ez_);
				Date fc_ = cq_?.BirthDateElement;
				CqlDate fd_ = _FHIRHelpers_4_0_001.ToDate(context, fc_);
				Quantity ff_ = (ct_ as Range)?.High;
				CqlQuantity fg_ = _FHIRHelpers_4_0_001.ToQuantity(context, ff_);
				CqlDate fh_ = context.Operators.Add(fd_, fg_);
				CqlDate fj_ = context.Operators.Add(fh_, de_);
				CqlInterval<CqlDate> fk_ = context.Operators.Interval(fa_, fj_, true, false);
				bool? fl_ = fk_?.highClosed;
				CqlInterval<CqlDateTime> fm_ = context.Operators.Interval(di_, eb_, et_, fl_);

				return fm_;
			}
			else if (g_())
			{
				DataType fn_ = condition?.Onset;
				CqlInterval<CqlDateTime> fo_ = this.Normalize_Interval(context, fn_);
				CqlDateTime fp_ = context.Operators.End(fo_);
				FhirDateTime fq_ = condition?.RecordedDateElement;
				CqlDateTime fr_ = _FHIRHelpers_4_0_001.ToDateTime(context, fq_);
				CqlInterval<CqlDateTime> fs_ = context.Operators.Interval(fp_, fr_, true, false);

				return fs_;
			}
			else
			{
				return null as CqlInterval<CqlDateTime>;
			}
		};

		return a_();
	}

    [CqlDeclaration("Prevalence Period")]
	public  CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
	{
		CqlInterval<CqlDateTime> a_()
		{
			bool b_()
			{
				CodeableConcept c_ = condition?.ClinicalStatus;
				CqlConcept d_ = _FHIRHelpers_4_0_001.ToConcept(context, c_);
				CqlCode e_ = this.active(context);
				CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
				bool? g_ = context.Operators.Equivalent(d_, f_);
				CqlConcept i_ = _FHIRHelpers_4_0_001.ToConcept(context, c_);
				CqlCode j_ = this.recurrence(context);
				CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
				bool? l_ = context.Operators.Equivalent(i_, k_);
				bool? m_ = context.Operators.Or(g_, l_);
				CqlConcept o_ = _FHIRHelpers_4_0_001.ToConcept(context, c_);
				CqlCode p_ = this.relapse(context);
				CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
				bool? r_ = context.Operators.Equivalent(o_, q_);
				bool? s_ = context.Operators.Or(m_, r_);

				return s_ ?? false;
			};
			if (b_())
			{
				DataType t_ = condition?.Onset;
				CqlInterval<CqlDateTime> u_ = this.Normalize_Interval(context, t_);
				CqlDateTime v_ = context.Operators.Start(u_);
				CqlInterval<CqlDateTime> w_ = this.Normalize_Abatement(context, condition);
				CqlDateTime x_ = context.Operators.End(w_);
				CqlInterval<CqlDateTime> y_ = context.Operators.Interval(v_, x_, true, true);

				return y_;
			}
			else
			{
				DataType z_ = condition?.Onset;
				CqlInterval<CqlDateTime> aa_ = this.Normalize_Interval(context, z_);
				CqlDateTime ab_ = context.Operators.Start(aa_);
				CqlInterval<CqlDateTime> ac_ = this.Normalize_Abatement(context, condition);
				CqlDateTime ad_ = context.Operators.End(ac_);
				CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(ab_, ad_, true, false);

				return ae_;
			}
		};

		return a_();
	}

    [CqlDeclaration("GetId")]
	public  string GetId(CqlContext context, string uri)
	{
		IEnumerable<string> a_ = context.Operators.Split(uri, "/");
		string b_ = context.Operators.Last<string>(a_);

		return b_;
	}

    [CqlDeclaration("EncounterDiagnosis")]
	public  IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
	{
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		Condition b_(Encounter.DiagnosisComponent D)
		{
			IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
			bool? e_(Condition C)
			{
				Id h_ = C?.IdElement;
				string i_ = _FHIRHelpers_4_0_001.ToString(context, h_);
				ResourceReference j_ = D?.Condition;
				FhirString k_ = j_?.ReferenceElement;
				string l_ = _FHIRHelpers_4_0_001.ToString(context, k_);
				string m_ = this.GetId(context, l_);
				bool? n_ = context.Operators.Equal(i_, m_);

				return n_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			Condition g_ = context.Operators.SingletonFrom<Condition>(f_);

			return g_;
		};
		IEnumerable<Condition> c_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);

		return c_;
	}

    [CqlDeclaration("GetCondition")]
	public  Condition GetCondition(CqlContext context, ResourceReference reference)
	{
		IEnumerable<Condition> a_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
		bool? b_(Condition C)
		{
			Id e_ = C?.IdElement;
			string f_ = _FHIRHelpers_4_0_001.ToString(context, e_);
			FhirString g_ = reference?.ReferenceElement;
			string h_ = _FHIRHelpers_4_0_001.ToString(context, g_);
			string i_ = this.GetId(context, h_);
			bool? j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("GetExtensions")]
	public  IEnumerable<Extension> GetExtensions(CqlContext context, DomainResource domainResource, string url)
	{
		List<Extension> a_ = domainResource?.Extension;
		bool? b_(Extension E)
		{
			string f_ = E?.Url;
			FhirUri g_ = context.Operators.Convert<FhirUri>(f_);
			string h_ = _FHIRHelpers_4_0_001.ToString(context, g_);
			string i_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			bool? j_ = context.Operators.Equal(h_, i_);

			return j_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
		Extension d_(Extension E) => 
			E;
		IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);

		return e_;
	}

    [CqlDeclaration("GetExtensions")]
	public  IEnumerable<Extension> GetExtensions(CqlContext context, Element element, string url)
	{
		List<Extension> a_ = element?.Extension;
		bool? b_(Extension E)
		{
			string f_ = E?.Url;
			FhirUri g_ = context.Operators.Convert<FhirUri>(f_);
			string h_ = _FHIRHelpers_4_0_001.ToString(context, g_);
			bool? i_ = context.Operators.Equal(h_, url);

			return i_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
		Extension d_(Extension E) => 
			E;
		IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);

		return e_;
	}

    [CqlDeclaration("GetExtension")]
	public  Extension GetExtension(CqlContext context, DomainResource domainResource, string url)
	{
		IEnumerable<Extension> a_ = this.GetExtensions(context, domainResource, url);
		Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("GetExtension")]
	public  Extension GetExtension(CqlContext context, Element element, string url)
	{
		IEnumerable<Extension> a_ = this.GetExtensions(context, element, url);
		Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("PresentOnAdmissionIndicator")]
	public  CodeableConcept PresentOnAdmissionIndicator(CqlContext context, Element element)
	{
		Extension a_ = this.GetExtension(context, element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");
		DataType b_ = a_?.Value;

		return b_ as CodeableConcept;
	}

    [CqlDeclaration("PrincipalDiagnosis")]
	public  Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
	{
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent D)
		{
			PositiveInt i_ = D?.RankElement;
			Integer j_ = context.Operators.Convert<Integer>(i_);
			int? k_ = _FHIRHelpers_4_0_001.ToInteger(context, j_);
			bool? l_ = context.Operators.Equal(k_, 1);

			return l_;
		};
		IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		Encounter.DiagnosisComponent d_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(c_);
		Encounter.DiagnosisComponent[] e_ = [
			d_,
		];
		Condition f_(Encounter.DiagnosisComponent PD)
		{
			IEnumerable<Condition> m_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
			bool? n_(Condition C)
			{
				Id q_ = C?.IdElement;
				string r_ = _FHIRHelpers_4_0_001.ToString(context, q_);
				ResourceReference s_ = PD?.Condition;
				FhirString t_ = s_?.ReferenceElement;
				string u_ = _FHIRHelpers_4_0_001.ToString(context, t_);
				string v_ = this.GetId(context, u_);
				bool? w_ = context.Operators.Equal(r_, v_);

				return w_;
			};
			IEnumerable<Condition> o_ = context.Operators.Where<Condition>(m_, n_);
			Condition p_ = context.Operators.SingletonFrom<Condition>(o_);

			return p_;
		};
		IEnumerable<Condition> g_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)e_, f_);
		Condition h_ = context.Operators.SingletonFrom<Condition>(g_);

		return h_;
	}

    [CqlDeclaration("GetLocation")]
	public  Location GetLocation(CqlContext context, ResourceReference reference)
	{
		IEnumerable<Location> a_ = context.Operators.RetrieveByValueSet<Location>(default, default);
		bool? b_(Location L)
		{
			Id e_ = L?.IdElement;
			string f_ = _FHIRHelpers_4_0_001.ToString(context, e_);
			FhirString g_ = reference?.ReferenceElement;
			string h_ = _FHIRHelpers_4_0_001.ToString(context, g_);
			string i_ = this.GetId(context, h_);
			bool? j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
		Location d_ = context.Operators.SingletonFrom<Location>(c_);

		return d_;
	}

    [CqlDeclaration("GetBaseExtensions")]
	public  IEnumerable<Extension> GetBaseExtensions(CqlContext context, DomainResource domainResource, string url)
	{
		List<Extension> a_ = domainResource?.Extension;
		bool? b_(Extension E)
		{
			string f_ = E?.Url;
			FhirUri g_ = context.Operators.Convert<FhirUri>(f_);
			string h_ = _FHIRHelpers_4_0_001.ToString(context, g_);
			string i_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
			bool? j_ = context.Operators.Equal(h_, i_);

			return j_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
		Extension d_(Extension E) => 
			E;
		IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);

		return e_;
	}

    [CqlDeclaration("GetBaseExtension")]
	public  Extension GetBaseExtension(CqlContext context, DomainResource domainResource, string url)
	{
		IEnumerable<Extension> a_ = this.GetBaseExtensions(context, domainResource, url);
		Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("BaseExtensions")]
    [CqlTag("description", "Returns any base-FHIR extensions defined on the given element with the specified id.")]
    [CqlTag("comment", "NOTE: Extensions are not the preferred approach, but are used as a way to access content that is defined by extensions but not yet surfaced in the CQL model info.")]
	public  IEnumerable<Extension> BaseExtensions(CqlContext context, Element element, string id)
	{
		List<Extension> a_ = element?.Extension;
		bool? b_(Extension E)
		{
			string f_ = E?.Url;
			FhirUri g_ = context.Operators.Convert<FhirUri>(f_);
			string h_ = _FHIRHelpers_4_0_001.ToString(context, g_);
			string i_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
			bool? j_ = context.Operators.Equal(h_, i_);

			return j_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
		Extension d_(Extension E) => 
			E;
		IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);

		return e_;
	}

    [CqlDeclaration("BaseExtension")]
    [CqlTag("description", "Returns the single base-FHIR extension (if present) on the given element with the specified id.")]
    [CqlTag("comment", "This function uses singleton from to ensure that a run-time exception is thrown if there is more than one extension on the given resource with the specified url.")]
	public  Extension BaseExtension(CqlContext context, Element element, string id)
	{
		IEnumerable<Extension> a_ = this.BaseExtensions(context, element, id);
		Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("GetMedicationCode")]
	public  CodeableConcept GetMedicationCode(CqlContext context, MedicationRequest request)
	{
		CodeableConcept a_()
		{
			bool b_()
			{
				DataType c_ = request?.Medication;
				bool d_ = c_ is CodeableConcept;

				return d_;
			};
			if (b_())
			{
				DataType e_ = request?.Medication;

				return e_ as CodeableConcept;
			}
			else
			{
				IEnumerable<Medication> f_ = context.Operators.RetrieveByValueSet<Medication>(default, default);
				bool? g_(Medication M)
				{
					Id k_ = M?.IdElement;
					string l_ = _FHIRHelpers_4_0_001.ToString(context, k_);
					DataType m_ = request?.Medication;
					FhirString n_ = (m_ as ResourceReference)?.ReferenceElement;
					string o_ = _FHIRHelpers_4_0_001.ToString(context, n_);
					string p_ = this.GetId(context, o_);
					bool? q_ = context.Operators.Equal(l_, p_);

					return q_;
				};
				IEnumerable<Medication> h_ = context.Operators.Where<Medication>(f_, g_);
				Medication i_ = context.Operators.SingletonFrom<Medication>(h_);
				CodeableConcept j_ = i_?.Code;

				return j_;
			}
		};

		return a_();
	}

    [CqlDeclaration("HasStart")]
	public  bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
	{
		CqlDateTime a_ = context.Operators.Start(period);
		CqlDateTime c_ = context.Operators.MinValue<CqlDateTime>();
		bool? d_ = context.Operators.Equal(a_, c_);
		bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
		bool? f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("HasEnd")]
	public  bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
	{
		CqlDateTime a_ = context.Operators.End(period);
		CqlDateTime c_ = context.Operators.MaxValue<CqlDateTime>();
		bool? d_ = context.Operators.Equal(a_, c_);
		bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
		bool? f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("Latest")]
	public  CqlDateTime Latest(CqlContext context, object choice)
	{
		CqlInterval<CqlDateTime> a_ = this.Normalize_Interval(context, choice);
		CqlInterval<CqlDateTime>[] b_ = [
			a_,
		];
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.HasEnd(context, period)) ?? false)
				{
					CqlDateTime g_ = context.Operators.End(period);

					return g_;
				}
				else
				{
					CqlDateTime h_ = context.Operators.Start(period);

					return h_;
				}
			};

			return f_();
		};
		IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
		CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

		return e_;
	}

    [CqlDeclaration("Earliest")]
	public  CqlDateTime Earliest(CqlContext context, object choice)
	{
		CqlInterval<CqlDateTime> a_ = this.Normalize_Interval(context, choice);
		CqlInterval<CqlDateTime>[] b_ = [
			a_,
		];
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.HasStart(context, period)) ?? false)
				{
					CqlDateTime g_ = context.Operators.Start(period);

					return g_;
				}
				else
				{
					CqlDateTime h_ = context.Operators.End(period);

					return h_;
				}
			};

			return f_();
		};
		IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
		CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

		return e_;
	}

}
