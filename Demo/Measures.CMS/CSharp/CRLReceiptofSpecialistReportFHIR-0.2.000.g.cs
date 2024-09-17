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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("CRLReceiptofSpecialistReportFHIR", "0.2.000")]
public static class CRLReceiptofSpecialistReportFHIR_0_2_000
{

    [CqlDeclaration("Consultant Report")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006")]
	public static CqlValueSet Consultant_Report(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public static CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
	public static CqlValueSet Ophthalmological_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", default);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public static CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public static CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public static CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public static CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Referral")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046")]
	public static CqlValueSet Referral(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046", default);

    [CqlDeclaration("Measurement Period")]
	public static CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("CRLReceiptofSpecialistReportFHIR-0.2.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public static Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Has Encounter during Measurement Period")]
	public static bool? Has_Encounter_during_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Ophthalmological_Services(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Preventive_Care__Established_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		bool? r_(Encounter Encounter)
		{
			Code<Encounter.EncounterStatus> u_ = Encounter?.StatusElement;
			Encounter.EncounterStatus? v_ = u_?.Value;
			Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
			bool? x_ = context.Operators.Equal(w_, "finished");
			CqlInterval<CqlDateTime> y_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Measurement_Period(context);
			Period z_ = Encounter?.Period;
			CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.ToInterval(context, z_);
			bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(y_, aa_, "day");
			bool? ac_ = context.Operators.And(x_, ab_);

			return ac_;
		};
		IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
		bool? t_ = context.Operators.Exists<Encounter>(s_);

		return t_;
	}

    [CqlDeclaration("First Referral during First 10 Months of Measurement Period")]
	public static (string ID, CqlDateTime AuthorDate)? First_Referral_during_First_10_Months_of_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Referral(context);
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		bool? c_(ServiceRequest ReferralOrder)
		{
			Code<RequestStatus> j_ = ReferralOrder?.StatusElement;
			RequestStatus? k_ = j_?.Value;
			Code<RequestStatus> l_ = context.Operators.Convert<Code<RequestStatus>>(k_);
			string m_ = context.Operators.Convert<string>(l_);
			string[] n_ = [
				"active",
				"completed",
			];
			bool? o_ = context.Operators.In<string>(m_, n_ as IEnumerable<string>);
			Code<RequestIntent> p_ = ReferralOrder?.IntentElement;
			RequestIntent? q_ = p_?.Value;
			Code<RequestIntent> r_ = context.Operators.Convert<Code<RequestIntent>>(q_);
			bool? s_ = context.Operators.Equal(r_, "order");
			bool? t_ = context.Operators.And(o_, s_);
			FhirDateTime u_ = ReferralOrder?.AuthoredOnElement;
			CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
			CqlInterval<CqlDateTime> w_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Measurement_Period(context);
			CqlDateTime x_ = context.Operators.Start(w_);
			CqlDateTime z_ = context.Operators.Start(w_);
			int? aa_ = context.Operators.DateTimeComponentFrom(z_, "year");
			CqlDate ab_ = context.Operators.Date(aa_, 10, 31);
			CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(ab_);
			CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(x_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlDateTime>(v_, ad_, "day");
			bool? af_ = context.Operators.And(t_, ae_);

			return af_;
		};
		IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
		(string ID, CqlDateTime AuthorDate)? e_(ServiceRequest ReferralOrder)
		{
			Id ag_ = ReferralOrder?.IdElement;
			string ah_ = ag_?.Value;
			FhirDateTime ai_ = ReferralOrder?.AuthoredOnElement;
			CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
			(string ID, CqlDateTime AuthorDate)? ak_ = (ah_, aj_);

			return ak_;
		};
		IEnumerable<(string ID, CqlDateTime AuthorDate)?> f_ = context.Operators.Select<ServiceRequest, (string ID, CqlDateTime AuthorDate)?>(d_, e_);
		object g_((string ID, CqlDateTime AuthorDate)? @this)
		{
			CqlDateTime al_ = @this?.AuthorDate;

			return al_;
		};
		IEnumerable<(string ID, CqlDateTime AuthorDate)?> h_ = context.Operators.SortBy<(string ID, CqlDateTime AuthorDate)?>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
		(string ID, CqlDateTime AuthorDate)? i_ = context.Operators.First<(string ID, CqlDateTime AuthorDate)?>(h_);

		return i_;
	}

    [CqlDeclaration("Initial Population")]
	public static bool? Initial_Population(CqlContext context)
	{
		bool? a_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Has_Encounter_during_Measurement_Period(context);
		(string ID, CqlDateTime AuthorDate)? b_ = CRLReceiptofSpecialistReportFHIR_0_2_000.First_Referral_during_First_10_Months_of_Measurement_Period(context);
		bool? c_ = context.Operators.Not((bool?)(b_ is null));
		bool? d_ = context.Operators.And(a_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator")]
	public static bool? Denominator(CqlContext context)
	{
		bool? a_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public static (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public static IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public static (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public static CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("TaskGetRequestID")]
	public static IEnumerable<string> TaskGetRequestID(CqlContext context, Task task)
	{
		List<ResourceReference> a_ = task?.BasedOn;
		string b_(ResourceReference Task)
		{
			FhirString d_ = Task?.ReferenceElement;
			string e_ = d_?.Value;
			string f_ = QICoreCommon_2_0_000.GetId(context, e_);

			return f_;
		};
		IEnumerable<string> c_ = context.Operators.Select<ResourceReference, string>((IEnumerable<ResourceReference>)a_, b_);

		return c_;
	}

    [CqlDeclaration("Referring Clinician Receives Consultant Report to Close Referral Loop")]
	public static bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(CqlContext context)
	{
		CqlValueSet a_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Consultant_Report(context);
		IEnumerable<Task> b_ = context.Operators.RetrieveByValueSet<Task>(a_, default);
		IEnumerable<Task> c_(Task ConsultantReportObtained)
		{
			(string ID, CqlDateTime AuthorDate)? f_ = CRLReceiptofSpecialistReportFHIR_0_2_000.First_Referral_during_First_10_Months_of_Measurement_Period(context);
			(string ID, CqlDateTime AuthorDate)?[] g_ = [
				f_,
			];
			bool? h_((string ID, CqlDateTime AuthorDate)? FirstReferral)
			{
				string l_ = FirstReferral?.ID;
				IEnumerable<string> m_ = CRLReceiptofSpecialistReportFHIR_0_2_000.TaskGetRequestID(context, ConsultantReportObtained);
				bool? n_ = context.Operators.In<string>(l_, m_);
				Period o_ = ConsultantReportObtained?.ExecutionPeriod;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(context, o_);
				CqlDateTime q_ = context.Operators.End(p_);
				CqlDateTime r_ = FirstReferral?.AuthorDate;
				bool? s_ = context.Operators.After(q_, r_, default);
				bool? t_ = context.Operators.And(n_, s_);
				Code<Task.TaskStatus> u_ = ConsultantReportObtained?.StatusElement;
				Task.TaskStatus? v_ = u_?.Value;
				Code<Task.TaskStatus> w_ = context.Operators.Convert<Code<Task.TaskStatus>>(v_);
				bool? x_ = context.Operators.Equal(w_, "completed");
				bool? y_ = context.Operators.And(t_, x_);
				CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.ToInterval(context, o_);
				CqlDateTime ab_ = context.Operators.End(aa_);
				CqlInterval<CqlDateTime> ac_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Measurement_Period(context);
				bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, "day");
				bool? ae_ = context.Operators.And(y_, ad_);

				return ae_;
			};
			IEnumerable<(string ID, CqlDateTime AuthorDate)?> i_ = context.Operators.Where<(string ID, CqlDateTime AuthorDate)?>((IEnumerable<(string ID, CqlDateTime AuthorDate)?>)g_, h_);
			Task j_((string ID, CqlDateTime AuthorDate)? FirstReferral) => 
				ConsultantReportObtained;
			IEnumerable<Task> k_ = context.Operators.Select<(string ID, CqlDateTime AuthorDate)?, Task>(i_, j_);

			return k_;
		};
		IEnumerable<Task> d_ = context.Operators.SelectMany<Task, Task>(b_, c_);
		bool? e_ = context.Operators.Exists<Task>(d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public static bool? Numerator(CqlContext context)
	{
		bool? a_ = CRLReceiptofSpecialistReportFHIR_0_2_000.Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(context);

		return a_;
	}

}
