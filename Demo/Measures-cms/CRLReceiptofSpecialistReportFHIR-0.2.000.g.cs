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
    internal Lazy<Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK> __First_Referral_during_First_10_Months_of_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __First_Referral_during_First_10_Months_of_Measurement_Period = new Lazy<Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK>(this.First_Referral_during_First_10_Months_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006", null);

    [CqlDeclaration("Consultant Report")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006")]
	public CqlValueSet Consultant_Report() => 
		__Consultant_Report.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Ophthalmological_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
	public CqlValueSet Ophthalmological_Services() => 
		__Ophthalmological_Services.Value;

	private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Referral_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046", null);

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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Has_Encounter_during_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Ophthalmological_Services();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		CqlValueSet l_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		CqlValueSet n_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		IEnumerable<Encounter> p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		bool? r_(Encounter Encounter)
		{
			Code<Encounter.EncounterStatus> u_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(Encounter?.StatusElement?.Value);
			bool? v_ = context.Operators.Equal(u_, "finished");
			CqlInterval<CqlDateTime> w_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(Encounter?.Period);
			bool? y_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, x_, "day");
			bool? z_ = context.Operators.And(v_, y_);

			return z_;
		};
		IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
		bool? t_ = context.Operators.Exists<Encounter>(s_);

		return t_;
	}

    [CqlDeclaration("Has Encounter during Measurement Period")]
	public bool? Has_Encounter_during_Measurement_Period() => 
		__Has_Encounter_during_Measurement_Period.Value;

	private Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK First_Referral_during_First_10_Months_of_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Referral();
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		bool? c_(ServiceRequest ReferralOrder)
		{
			Code<RequestStatus> j_ = context.Operators.Convert<Code<RequestStatus>>(ReferralOrder?.StatusElement?.Value);
			string k_ = context.Operators.Convert<string>(j_);
			string[] l_ = new string[]
			{
				"active",
				"completed",
			};
			bool? m_ = context.Operators.In<string>(k_, (l_ as IEnumerable<string>));
			Code<RequestIntent> n_ = context.Operators.Convert<Code<RequestIntent>>(ReferralOrder?.IntentElement?.Value);
			bool? o_ = context.Operators.Equal(n_, "order");
			bool? p_ = context.Operators.And(m_, o_);
			CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(ReferralOrder?.AuthoredOnElement);
			CqlInterval<CqlDateTime> r_ = this.Measurement_Period();
			CqlDateTime s_ = context.Operators.Start(r_);
			CqlDateTime u_ = context.Operators.Start(r_);
			int? v_ = context.Operators.DateTimeComponentFrom(u_, "year");
			CqlDate w_ = context.Operators.Date(v_, 10, 31);
			CqlDateTime x_ = context.Operators.ConvertDateToDateTime(w_);
			CqlInterval<CqlDateTime> y_ = context.Operators.Interval(s_, x_, true, true);
			bool? z_ = context.Operators.In<CqlDateTime>(q_, y_, "day");
			bool? aa_ = context.Operators.And(p_, z_);

			return aa_;
		};
		IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
		Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK e_(ServiceRequest ReferralOrder)
		{
			CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(ReferralOrder?.AuthoredOnElement);
			Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK ac_ = new Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK
			{
				ID = ReferralOrder?.IdElement?.Value,
				AuthorDate = ab_,
			};

			return ac_;
		};
		IEnumerable<Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK> f_ = context.Operators.Select<ServiceRequest, Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK>(d_, e_);
		object g_(Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK @this) => 
			@this?.AuthorDate;
		IEnumerable<Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK> h_ = context.Operators.SortBy<Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
		Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK i_ = context.Operators.First<Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK>(h_);

		return i_;
	}

    [CqlDeclaration("First Referral during First 10 Months of Measurement Period")]
	public Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK First_Referral_during_First_10_Months_of_Measurement_Period() => 
		__First_Referral_during_First_10_Months_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		bool? a_ = this.Has_Encounter_during_Measurement_Period();
		Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK b_ = this.First_Referral_during_First_10_Months_of_Measurement_Period();
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

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
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
		string a_(ResourceReference Task)
		{
			string c_ = QICoreCommon_2_0_000.GetId(Task?.ReferenceElement?.Value);

			return c_;
		};
		IEnumerable<string> b_ = context.Operators.Select<ResourceReference, string>((task?.BasedOn as IEnumerable<ResourceReference>), a_);

		return b_;
	}

	private bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop_Value()
	{
		CqlValueSet a_ = this.Consultant_Report();
		IEnumerable<Task> b_ = context.Operators.RetrieveByValueSet<Task>(a_, null);
		IEnumerable<Task> c_(Task ConsultantReportObtained)
		{
			Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK f_ = this.First_Referral_during_First_10_Months_of_Measurement_Period();
			Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK[] g_ = new Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK[]
			{
				f_,
			};
			bool? h_(Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK FirstReferral)
			{
				IEnumerable<string> l_ = this.TaskGetRequestID(ConsultantReportObtained);
				bool? m_ = context.Operators.In<string>(FirstReferral?.ID, l_);
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(ConsultantReportObtained?.ExecutionPeriod);
				CqlDateTime o_ = context.Operators.End(n_);
				bool? p_ = context.Operators.After(o_, FirstReferral?.AuthorDate, null);
				bool? q_ = context.Operators.And(m_, p_);
				Code<Task.TaskStatus> r_ = context.Operators.Convert<Code<Task.TaskStatus>>(ConsultantReportObtained?.StatusElement?.Value);
				bool? s_ = context.Operators.Equal(r_, "completed");
				bool? t_ = context.Operators.And(q_, s_);
				CqlDateTime v_ = context.Operators.End(n_);
				CqlInterval<CqlDateTime> w_ = this.Measurement_Period();
				bool? x_ = context.Operators.In<CqlDateTime>(v_, w_, "day");
				bool? y_ = context.Operators.And(t_, x_);

				return y_;
			};
			IEnumerable<Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK> i_ = context.Operators.Where<Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK>(g_, h_);
			Task j_(Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK FirstReferral) => 
				ConsultantReportObtained;
			IEnumerable<Task> k_ = context.Operators.Select<Tuple_BQRHOWGHNMjBJPPZJZXVMjCPK, Task>(i_, j_);

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
