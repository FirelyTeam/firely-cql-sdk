﻿using System;
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
[CqlLibrary("HIVRetentionFHIR", "0.1.000")]
public class HIVRetentionFHIR_0_1_000(
    CQMCommon_2_0_000 _CQMCommon_2_0_000,
    FHIRHelpers_4_3_000 _FHIRHelpers_4_3_000,
    QICoreCommon_2_0_000 _QICoreCommon_2_0_000,
    SupplementalDataElements_3_4_000 _SupplementalDataElements_3_4_000,
    CumulativeMedicationDuration_4_0_000 _CumulativeMedicationDuration_4_0_000)
{

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public  CqlValueSet Annual_Wellness_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);

    [CqlDeclaration("Face-to-Face Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048")]
	public  CqlValueSet Face_to_Face_Interaction(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", default);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public  CqlValueSet HIV(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", default);

    [CqlDeclaration("HIV Viral Load")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002")]
	public  CqlValueSet HIV_Viral_Load(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public  CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public  CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public  CqlValueSet Outpatient_Consultation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public  CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public  CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public  CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public  CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public  CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Preventive Care Services Other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150")]
	public  CqlValueSet Preventive_Care_Services_Other(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", default);

    [CqlDeclaration("CPT")]
	public  CqlCode[] CPT(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HIVRetentionFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("SDE Payer")]
	public  IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = _SupplementalDataElements_3_4_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public  (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		List<Extension> a_()
		{
			bool i_()
			{
				Patient j_ = this.Patient(context);
				bool k_ = j_ is DomainResource;

				return k_;
			};
			if (i_())
			{
				Patient l_ = this.Patient(context);

				return (l_ as DomainResource).Extension;
			}
			else
			{
				return default;
			}
		};
		bool? b_(Extension @this)
		{
			string m_ = @this?.Url;
			FhirString n_ = context.Operators.Convert<FhirString>(m_);
			string o_ = _FHIRHelpers_4_3_000.ToString(context, n_);
			bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return p_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(a_()), b_);
		Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
		Extension[] e_ = [
			d_,
		];
		(IEnumerable<CqlCode> codes, string display)? f_(Extension E)
		{
			bool? q_(Extension @this)
			{
				string al_ = @this?.Url;
				FhirString am_ = context.Operators.Convert<FhirString>(al_);
				string an_ = _FHIRHelpers_4_3_000.ToString(context, am_);
				bool? ao_ = context.Operators.Equal(an_, "ombCategory");

				return ao_;
			};
			IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
					? (E as Element).Extension
					: default), q_);
			object s_(Extension @this)
			{
				DataType ap_ = @this?.Value;

				return ap_;
			};
			IEnumerable<object> t_ = context.Operators.Select<Extension, object>(r_, s_);
			object u_ = context.Operators.SingletonFrom<object>(t_);
			CqlCode v_ = _FHIRHelpers_4_3_000.ToCode(context, u_ as Coding);
			CqlCode[] w_ = [
				v_,
			];
			bool? x_(Extension @this)
			{
				string aq_ = @this?.Url;
				FhirString ar_ = context.Operators.Convert<FhirString>(aq_);
				string as_ = _FHIRHelpers_4_3_000.ToString(context, ar_);
				bool? at_ = context.Operators.Equal(as_, "detailed");

				return at_;
			};
			IEnumerable<Extension> y_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
					? (E as Element).Extension
					: default), x_);
			object z_(Extension @this)
			{
				DataType au_ = @this?.Value;

				return au_;
			};
			IEnumerable<object> aa_ = context.Operators.Select<Extension, object>(y_, z_);
			CqlCode ab_(object @this)
			{
				CqlCode av_ = _FHIRHelpers_4_3_000.ToCode(context, @this as Coding);

				return av_;
			};
			IEnumerable<CqlCode> ac_ = context.Operators.Select<object, CqlCode>(aa_, ab_);
			IEnumerable<CqlCode> ad_ = context.Operators.Union<CqlCode>(w_ as IEnumerable<CqlCode>, ac_);
			bool? ae_(Extension @this)
			{
				string aw_ = @this?.Url;
				FhirString ax_ = context.Operators.Convert<FhirString>(aw_);
				string ay_ = _FHIRHelpers_4_3_000.ToString(context, ax_);
				bool? az_ = context.Operators.Equal(ay_, "text");

				return az_;
			};
			IEnumerable<Extension> af_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
					? (E as Element).Extension
					: default), ae_);
			DataType ag_(Extension @this)
			{
				DataType ba_ = @this?.Value;

				return ba_;
			};
			IEnumerable<DataType> ah_ = context.Operators.Select<Extension, DataType>(af_, ag_);
			DataType ai_ = context.Operators.SingletonFrom<DataType>(ah_);
			string aj_ = context.Operators.Convert<string>(ai_);
			(IEnumerable<CqlCode> codes, string display)? ak_ = (ad_, aj_);

			return ak_;
		};
		IEnumerable<(IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.Select<Extension, (IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
		(IEnumerable<CqlCode> codes, string display)? h_ = context.Operators.SingletonFrom<(IEnumerable<CqlCode> codes, string display)?>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Race")]
	public  (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		List<Extension> a_()
		{
			bool i_()
			{
				Patient j_ = this.Patient(context);
				bool k_ = j_ is DomainResource;

				return k_;
			};
			if (i_())
			{
				Patient l_ = this.Patient(context);

				return (l_ as DomainResource).Extension;
			}
			else
			{
				return default;
			}
		};
		bool? b_(Extension @this)
		{
			string m_ = @this?.Url;
			FhirString n_ = context.Operators.Convert<FhirString>(m_);
			string o_ = _FHIRHelpers_4_3_000.ToString(context, n_);
			bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return p_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(a_()), b_);
		Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
		Extension[] e_ = [
			d_,
		];
		(IEnumerable<CqlCode> codes, string display)? f_(Extension R)
		{
			bool? q_(Extension @this)
			{
				string ak_ = @this?.Url;
				FhirString al_ = context.Operators.Convert<FhirString>(ak_);
				string am_ = _FHIRHelpers_4_3_000.ToString(context, al_);
				bool? an_ = context.Operators.Equal(am_, "ombCategory");

				return an_;
			};
			IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
					? (R as Element).Extension
					: default), q_);
			object s_(Extension @this)
			{
				DataType ao_ = @this?.Value;

				return ao_;
			};
			IEnumerable<object> t_ = context.Operators.Select<Extension, object>(r_, s_);
			CqlCode u_(object @this)
			{
				CqlCode ap_ = _FHIRHelpers_4_3_000.ToCode(context, @this as Coding);

				return ap_;
			};
			IEnumerable<CqlCode> v_ = context.Operators.Select<object, CqlCode>(t_, u_);
			bool? w_(Extension @this)
			{
				string aq_ = @this?.Url;
				FhirString ar_ = context.Operators.Convert<FhirString>(aq_);
				string as_ = _FHIRHelpers_4_3_000.ToString(context, ar_);
				bool? at_ = context.Operators.Equal(as_, "detailed");

				return at_;
			};
			IEnumerable<Extension> x_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
					? (R as Element).Extension
					: default), w_);
			object y_(Extension @this)
			{
				DataType au_ = @this?.Value;

				return au_;
			};
			IEnumerable<object> z_ = context.Operators.Select<Extension, object>(x_, y_);
			CqlCode aa_(object @this)
			{
				CqlCode av_ = _FHIRHelpers_4_3_000.ToCode(context, @this as Coding);

				return av_;
			};
			IEnumerable<CqlCode> ab_ = context.Operators.Select<object, CqlCode>(z_, aa_);
			IEnumerable<CqlCode> ac_ = context.Operators.Union<CqlCode>(v_, ab_);
			bool? ad_(Extension @this)
			{
				string aw_ = @this?.Url;
				FhirString ax_ = context.Operators.Convert<FhirString>(aw_);
				string ay_ = _FHIRHelpers_4_3_000.ToString(context, ax_);
				bool? az_ = context.Operators.Equal(ay_, "text");

				return az_;
			};
			IEnumerable<Extension> ae_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
					? (R as Element).Extension
					: default), ad_);
			DataType af_(Extension @this)
			{
				DataType ba_ = @this?.Value;

				return ba_;
			};
			IEnumerable<DataType> ag_ = context.Operators.Select<Extension, DataType>(ae_, af_);
			DataType ah_ = context.Operators.SingletonFrom<DataType>(ag_);
			string ai_ = context.Operators.Convert<string>(ah_);
			(IEnumerable<CqlCode> codes, string display)? aj_ = (ac_, ai_);

			return aj_;
		};
		IEnumerable<(IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.Select<Extension, (IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
		(IEnumerable<CqlCode> codes, string display)? h_ = context.Operators.SingletonFrom<(IEnumerable<CqlCode> codes, string display)?>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Sex")]
	public  CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = _SupplementalDataElements_3_4_000.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period")]
	public  bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.HIV(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition HIVDx)
		{
			CqlInterval<CqlDateTime> f_ = _QICoreCommon_2_0_000.prevalenceInterval(context, HIVDx);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlQuantity j_ = context.Operators.Quantity(240m, "days");
			CqlDateTime k_ = context.Operators.Add(i_, j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
			bool? n_ = context.Operators.SameOrBefore(g_, m_, default);
			bool? o_ = _QICoreCommon_2_0_000.isActive(context, HIVDx);
			bool? p_ = context.Operators.And(n_, o_);

			return p_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Qualifying Encounter During First 240 Days of Measurement Period")]
	public  bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Outpatient_Consultation(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Annual_Wellness_Visit(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Face_to_Face_Interaction(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, default);
		CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, default);
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, default);
		CqlValueSet z_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, default);
		IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Preventive_Care_Services_Other(context);
		IEnumerable<Encounter> ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, default);
		IEnumerable<Encounter> af_ = context.Operators.Union<Encounter>(ac_, ae_);
		bool? ag_(Encounter QualifyingEncounter)
		{
			CqlInterval<CqlDateTime> aj_ = this.Measurement_Period(context);
			CqlDateTime ak_ = context.Operators.Start(aj_);
			CqlDateTime am_ = context.Operators.Start(aj_);
			CqlQuantity an_ = context.Operators.Quantity(240m, "days");
			CqlDateTime ao_ = context.Operators.Add(am_, an_);
			CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(ak_, ao_, true, true);
			Period aq_ = QualifyingEncounter?.Period;
			CqlInterval<CqlDateTime> ar_ = _FHIRHelpers_4_3_000.ToInterval(context, aq_);
			bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, ar_, "day");

			return as_;
		};
		IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
		bool? ai_ = context.Operators.Exists<Encounter>(ah_);

		return ai_;
	}

    [CqlDeclaration("Initial Population")]
	public  bool? Initial_Population(CqlContext context)
	{
		bool? a_ = this.Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(context);
		bool? b_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(context);
		bool? c_ = context.Operators.And(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator")]
	public  bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Encounter During Measurement Period With HIV")]
	public  IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV(CqlContext context)
	{
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Outpatient_Consultation(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Annual_Wellness_Visit(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Face_to_Face_Interaction(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, default);
		CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, default);
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, default);
		CqlValueSet z_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, default);
		IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Preventive_Care_Services_Other(context);
		IEnumerable<Encounter> ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, default);
		IEnumerable<Encounter> af_ = context.Operators.Union<Encounter>(ac_, ae_);
		IEnumerable<Encounter> ag_(Encounter ValidEncounter)
		{
			CqlValueSet ai_ = this.HIV(context);
			IEnumerable<Condition> aj_ = context.Operators.RetrieveByValueSet<Condition>(ai_, default);
			bool? ak_(Condition HIVDiagnosis)
			{
				CqlInterval<CqlDateTime> ao_ = this.Measurement_Period(context);
				Period ap_ = ValidEncounter?.Period;
				CqlInterval<CqlDateTime> aq_ = _FHIRHelpers_4_3_000.ToInterval(context, ap_);
				bool? ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, aq_, default);
				CqlInterval<CqlDateTime> as_()
				{
					bool az_()
					{
						CqlInterval<CqlDateTime> ba_ = _QICoreCommon_2_0_000.prevalenceInterval(context, HIVDiagnosis);
						CqlDateTime bb_ = context.Operators.Start(ba_);

						return bb_ is null;
					};
					if (az_())
					{
						return default;
					}
					else
					{
						CqlInterval<CqlDateTime> bc_ = _QICoreCommon_2_0_000.prevalenceInterval(context, HIVDiagnosis);
						CqlDateTime bd_ = context.Operators.Start(bc_);
						CqlDateTime bf_ = context.Operators.Start(bc_);
						CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bd_, bf_, true, true);

						return bg_;
					}
				};
				CqlInterval<CqlDateTime> au_ = _FHIRHelpers_4_3_000.ToInterval(context, ap_);
				bool? av_ = context.Operators.SameOrBefore(as_(), au_, "day");
				bool? aw_ = context.Operators.And(ar_, av_);
				bool? ax_ = _QICoreCommon_2_0_000.isActive(context, HIVDiagnosis);
				bool? ay_ = context.Operators.And(aw_, ax_);

				return ay_;
			};
			IEnumerable<Condition> al_ = context.Operators.Where<Condition>(aj_, ak_);
			Encounter am_(Condition HIVDiagnosis) => 
				ValidEncounter;
			IEnumerable<Encounter> an_ = context.Operators.Select<Condition, Encounter>(al_, am_);

			return an_;
		};
		IEnumerable<Encounter> ah_ = context.Operators.SelectMany<Encounter, Encounter>(af_, ag_);

		return ah_;
	}

    [CqlDeclaration("Has HIV Viral Load Test During Measurement Period")]
	public  bool? Has_HIV_Viral_Load_Test_During_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.HIV_Viral_Load(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation ViralLoadTest)
		{
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
			DataType g_ = ViralLoadTest?.Effective;
			object h_ = _FHIRHelpers_4_3_000.ToValue(context, g_);
			CqlInterval<CqlDateTime> i_ = _QICoreCommon_2_0_000.ToInterval(context, h_);
			bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, "day");

			return j_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		bool? e_ = context.Operators.Exists<Observation>(d_);

		return e_;
	}

    [CqlDeclaration("Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart")]
	public  bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_During_Measurement_Period_With_HIV(context);
		IEnumerable<Encounter> b_(Encounter EncounterWithHIV)
		{
			CqlValueSet e_ = this.HIV_Viral_Load(context);
			IEnumerable<Observation> f_ = context.Operators.RetrieveByValueSet<Observation>(e_, default);
			bool? g_(Observation ViralLoadTest)
			{
				CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
				DataType l_ = ViralLoadTest?.Effective;
				object m_ = _FHIRHelpers_4_3_000.ToValue(context, l_);
				CqlInterval<CqlDateTime> n_ = _QICoreCommon_2_0_000.ToInterval(context, m_);
				bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, n_, default);
				object q_ = _FHIRHelpers_4_3_000.ToValue(context, l_);
				CqlInterval<CqlDateTime> r_ = _QICoreCommon_2_0_000.ToInterval(context, q_);
				CqlDateTime s_ = context.Operators.Start(r_);
				Period t_ = EncounterWithHIV?.Period;
				CqlInterval<CqlDateTime> u_ = _FHIRHelpers_4_3_000.ToInterval(context, t_);
				CqlDateTime v_ = context.Operators.End(u_);
				CqlQuantity w_ = context.Operators.Quantity(90m, "days");
				CqlDateTime x_ = context.Operators.Add(v_, w_);
				bool? y_ = context.Operators.SameOrAfter(s_, x_, "day");
				CqlInterval<CqlDateTime> aa_ = _FHIRHelpers_4_3_000.ToInterval(context, t_);
				CqlDateTime ab_ = context.Operators.Start(aa_);
				object ad_ = _FHIRHelpers_4_3_000.ToValue(context, l_);
				CqlInterval<CqlDateTime> ae_ = _QICoreCommon_2_0_000.ToInterval(context, ad_);
				CqlDateTime af_ = context.Operators.End(ae_);
				CqlDateTime ah_ = context.Operators.Add(af_, w_);
				bool? ai_ = context.Operators.SameOrAfter(ab_, ah_, "day");
				bool? aj_ = context.Operators.Or(y_, ai_);
				bool? ak_ = context.Operators.And(o_, aj_);

				return ak_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			Encounter i_(Observation ViralLoadTest) => 
				EncounterWithHIV;
			IEnumerable<Encounter> j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		bool? d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Has Two Encounters With HIV At Least 90 Days Apart")]
	public  bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_During_Measurement_Period_With_HIV(context);
		IEnumerable<Encounter> b_(Encounter EncounterWithHIV)
		{
			IEnumerable<Encounter> e_ = this.Encounter_During_Measurement_Period_With_HIV(context);
			bool? f_(Encounter AnotherEncounterWithHIV)
			{
				bool? j_ = context.Operators.Equivalent(EncounterWithHIV, AnotherEncounterWithHIV);
				bool? k_ = context.Operators.Not(j_);
				Period l_ = AnotherEncounterWithHIV?.Period;
				CqlInterval<CqlDateTime> m_ = _FHIRHelpers_4_3_000.ToInterval(context, l_);
				CqlDateTime n_ = context.Operators.Start(m_);
				Period o_ = EncounterWithHIV?.Period;
				CqlInterval<CqlDateTime> p_ = _FHIRHelpers_4_3_000.ToInterval(context, o_);
				CqlDateTime q_ = context.Operators.End(p_);
				CqlQuantity r_ = context.Operators.Quantity(90m, "days");
				CqlDateTime s_ = context.Operators.Add(q_, r_);
				bool? t_ = context.Operators.SameOrAfter(n_, s_, "day");
				bool? u_ = context.Operators.And(k_, t_);

				return u_;
			};
			IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
			Encounter h_(Encounter AnotherEncounterWithHIV) => 
				EncounterWithHIV;
			IEnumerable<Encounter> i_ = context.Operators.Select<Encounter, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		bool? d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Numerator")]
	public  bool? Numerator(CqlContext context)
	{
		bool? a_ = this.Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(context);
		bool? b_ = this.Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(context);
		bool? c_ = context.Operators.Or(a_, b_);

		return c_;
	}

}
