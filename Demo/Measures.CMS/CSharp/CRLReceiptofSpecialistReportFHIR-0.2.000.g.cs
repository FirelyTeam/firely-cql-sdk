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
[CqlLibrary("CRLReceiptofSpecialistReportFHIR", "0.2.000")]
public class CRLReceiptofSpecialistReportFHIR_0_2_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Consultant_Report;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Ophthalmological_Services;
    internal Lazy<CqlValueSet> __Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care__Established_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Referral;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Has_Encounter_during_Measurement_Period;
    internal Lazy<(string ID, CqlDateTime AuthorDate)?> __First_Referral_during_First_10_Months_of_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<bool?> __Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop;
    internal Lazy<bool?> __Numerator;

    #endregion
    public CRLReceiptofSpecialistReportFHIR_0_2_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Consultant_Report = new Lazy<CqlValueSet>(this.Consultant_Report_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Ophthalmological_Services = new Lazy<CqlValueSet>(this.Ophthalmological_Services_Value);
        __Preventive_Care_Services___Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Preventive_Care__Established_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care__Established_Office_Visit__0_to_17_Value);
        __Referral = new Lazy<CqlValueSet>(this.Referral_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Has_Encounter_during_Measurement_Period = new Lazy<bool?>(this.Has_Encounter_during_Measurement_Period_Value);
        __First_Referral_during_First_10_Months_of_Measurement_Period = new Lazy<(string ID, CqlDateTime AuthorDate)?>(this.First_Referral_during_First_10_Months_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop = new Lazy<bool?>(this.Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Consultant_Report_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006", default);

    [CqlDeclaration("Consultant Report")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006")]
	public CqlValueSet Consultant_Report() => 
		__Consultant_Report.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Ophthalmological_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", default);

    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
	public CqlValueSet Ophthalmological_Services() => 
		__Ophthalmological_Services.Value;

	private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Referral_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046", default);

    [CqlDeclaration("Referral")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046")]
	public CqlValueSet Referral() => 
		__Referral.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("CRLReceiptofSpecialistReportFHIR-0.2.000", "Measurement Period", c_);

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

	private bool? Has_Encounter_during_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Ophthalmological_Services();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet n_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		bool? r_(Encounter Encounter)
		{
			Code<Encounter.EncounterStatus> u_ = Encounter?.StatusElement;
			Encounter.EncounterStatus? v_ = u_?.Value;
			Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
			bool? x_ = context.Operators.Equal(w_, "finished");
			CqlInterval<CqlDateTime> y_ = this.Measurement_Period();
			Period z_ = Encounter?.Period;
			CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.ToInterval(z_);
			bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(y_, aa_, "day");
			bool? ac_ = context.Operators.And(x_, ab_);

			return ac_;
		};
		IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
		bool? t_ = context.Operators.Exists<Encounter>(s_);

		return t_;
	}

    [CqlDeclaration("Has Encounter during Measurement Period")]
	public bool? Has_Encounter_during_Measurement_Period() => 
		__Has_Encounter_during_Measurement_Period.Value;

	private (string ID, CqlDateTime AuthorDate)? First_Referral_during_First_10_Months_of_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Referral();
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
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
			CqlInterval<CqlDateTime> w_ = this.Measurement_Period();
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

    [CqlDeclaration("First Referral during First 10 Months of Measurement Period")]
	public (string ID, CqlDateTime AuthorDate)? First_Referral_during_First_10_Months_of_Measurement_Period() => 
		__First_Referral_during_First_10_Months_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		bool? a_ = this.Has_Encounter_during_Measurement_Period();
		(string ID, CqlDateTime AuthorDate)? b_ = this.First_Referral_during_First_10_Months_of_Measurement_Period();
		bool? c_ = context.Operators.Not((bool?)(b_ is null));
		bool? d_ = context.Operators.And(a_, c_);

		return d_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

    [CqlDeclaration("TaskGetRequestID")]
	public IEnumerable<string> TaskGetRequestID(Task task)
	{
		List<ResourceReference> a_ = task?.BasedOn;
		string b_(ResourceReference Task)
		{
			FhirString d_ = Task?.ReferenceElement;
			string e_ = d_?.Value;
			string f_ = QICoreCommon_2_0_000.GetId(e_);

			return f_;
		};
		IEnumerable<string> c_ = context.Operators.Select<ResourceReference, string>((IEnumerable<ResourceReference>)a_, b_);

		return c_;
	}

	private bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop_Value()
	{
		CqlValueSet a_ = this.Consultant_Report();
		IEnumerable<Task> b_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-task"));
		IEnumerable<Task> c_(Task ConsultantReportObtained)
		{
			(string ID, CqlDateTime AuthorDate)? f_ = this.First_Referral_during_First_10_Months_of_Measurement_Period();
			(string ID, CqlDateTime AuthorDate)?[] g_ = [
				f_,
			];
			bool? h_((string ID, CqlDateTime AuthorDate)? FirstReferral)
			{
				string l_ = FirstReferral?.ID;
				IEnumerable<string> m_ = this.TaskGetRequestID(ConsultantReportObtained);
				bool? n_ = context.Operators.In<string>(l_, m_);
				Period o_ = ConsultantReportObtained?.ExecutionPeriod;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				CqlDateTime q_ = context.Operators.End(p_);
				CqlDateTime r_ = FirstReferral?.AuthorDate;
				bool? s_ = context.Operators.After(q_, r_, default);
				bool? t_ = context.Operators.And(n_, s_);
				Code<Task.TaskStatus> u_ = ConsultantReportObtained?.StatusElement;
				Task.TaskStatus? v_ = u_?.Value;
				Code<Task.TaskStatus> w_ = context.Operators.Convert<Code<Task.TaskStatus>>(v_);
				bool? x_ = context.Operators.Equal(w_, "completed");
				bool? y_ = context.Operators.And(t_, x_);
				CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.ToInterval(o_);
				CqlDateTime ab_ = context.Operators.End(aa_);
				CqlInterval<CqlDateTime> ac_ = this.Measurement_Period();
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

    [CqlDeclaration("Referring Clinician Receives Consultant Report to Close Referral Loop")]
	public bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop() => 
		__Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop.Value;

	private bool? Numerator_Value()
	{
		bool? a_ = this.Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
